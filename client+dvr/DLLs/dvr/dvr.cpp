#include "dvr.h"

class dvr
{
	public:
		// attributes
		int port;
		int resCamX[16];
		int resCamY[16];
		bool bwCam[16];

		IMAGE * images;
		SOCKET client;
		SOCKET server;
		int shape;
		int idx;

		// dvr methods
		dvr()
		{
			idx = 0;
		}
		int Listen (int);
		bool RecvResCam (int, int);
		int RecvBWCam (int, int);

		bool AddImage (IMAGE);
		IMAGE GetFirstImage ();
		IMAGE GetNextImage ();
		IMAGE GetLastImage ();
		bool DeleteImage (IMAGE, int);
		bool DeleteAllImages ();

		void Process(IMAGE);
};


extern "C"
{
	// test methods
	__declspec(dllexport) int getResX(dvr* d, int cam)
	{
		return d->resCamX[cam];
	}

	__declspec(dllexport) int getResY(dvr* d, int cam)
	{
		return d->resCamY[cam];
	}



	__declspec(dllexport) bool GetBW(dvr* d, char cam[])
	{
		return d->bwCam[atoi(cam)];
	}

	// useful methods
	__declspec(dllexport) dvr* createDVR()
	{
		return new dvr();
	}

	//__declspec(dllexport) IMAGE* CreateIMAGE()
	//{
	//	IMAGE *img = (IMAGE*)malloc(sizeof(IMAGE));
	//	return img;
	//}

	__declspec(dllexport) bool Listen(dvr *d, int port)
	{
		SOCKET server = INVALID_SOCKET;
	    WSADATA wsaData;
		sockaddr_in local;
		
		int wsaret=WSAStartup(0x101,&wsaData);

		if(wsaret!=0)
			return false;

		local.sin_family=AF_INET; //Address family
	    local.sin_addr.s_addr=INADDR_ANY; //Wild card IP address
	    local.sin_port=htons((u_short)port); //port to use
	
		server=socket(AF_INET,SOCK_STREAM,0);
		if(server==INVALID_SOCKET)
			return false;

		if(bind(server,(sockaddr*)&local,sizeof(local))!=0)
			return false;

		if(listen(server,1)!=0)
			return false;
		
		SOCKET client = INVALID_SOCKET;
		sockaddr_in from;
		int fromlen=sizeof(from);

		char temp[3];
		client=accept(server, (struct sockaddr*)&from,&fromlen);
		memset(temp, 0x00, 3);
		sprintf_s(temp,"We");

		//we simply send this string to the client
        send(client,temp,strlen(temp),0);
		
		d->client = client;
		d->server = server;

		return true;
	}

	__declspec(dllexport) int RecvResCam (dvr* d, int cam)
	{
		// receive resXY
		char *resX = (char*)calloc(10, sizeof(char));
		char *resY = (char*)calloc(10, sizeof(char));

		int ret = recv(d->client, resY, 10*sizeof(char), 0);
		ret += recv(d->client, resX, 10*sizeof(char), 0);

		d->resCamX[cam] = atoi(resX);
		d->resCamY[cam] = atoi(resY);

		return atoi(resX);
	}

	__declspec(dllexport) bool RecvBWCam (dvr* d)
	{
		// receive resXY
		char *bw = (char*)calloc(10, sizeof(char));
		char *cam = (char*)calloc(10, sizeof(char));

		int ret = recv(d->client, bw, 10*sizeof(char), 0);
		ret += recv(d->client, cam, 10*sizeof(char), 0);
		
		if (bw[0] == '1')
			d->bwCam[atoi(cam)] = true;
		else
			d->bwCam[atoi(cam)] = false;
		
		return ret > 0;
	}



	__declspec(dllexport) bool CloseConnection (dvr* d)
	{
		closesocket(d->client);
		closesocket(d->server); // se inchide?!
		WSACleanup();
		return true;
	}

	__declspec(dllexport) IMAGE* GetImage(dvr* d, char filePath[])
	{
		d->idx ++;
		IMAGE* img = (IMAGE*)malloc(sizeof(IMAGE));
		
		FILE *in;
		BITMAPFILEHEADER bfh;
		BITMAPINFOHEADER bih;

		// open image
		fopen_s(&in, filePath, "rb");
	
		if (in == NULL)
			return  NULL;
	
		// read bitmap file header
		fread(&bfh, sizeof(BITMAPFILEHEADER), 1, in);
		if (bfh.bfType != 0x4D42)
		{
			fclose(in);
			return NULL;
		}

		// read bitmap info header
		fread(&bih, sizeof(BITMAPINFOHEADER), 1, in);

		// fill all image fields 
		img->Height = bih.biHeight;
		img->Width = bih.biWidth;
		img->BitCount = bih.biBitCount;
		img->Format = 0;
		img->ByteArrayLen = bih.biSizeImage;

		char *bitmapImage = (char*)malloc(bih.biSizeImage * sizeof(char));
		fread(bitmapImage, bih.biSizeImage, 1, in);

		img->ImageData = (char*)malloc(bih.biSizeImage * sizeof(char));
		img->ImageData = bitmapImage;

		// add image to dvr's IMAGE array <=> AddImage();
		if (d->idx == 1)
			d->images = (IMAGE*)malloc(sizeof(IMAGE));
		else
			d->images = (IMAGE*)realloc(d->images, d->idx * sizeof(IMAGE));
	
		d->images[d->idx-1] = *img;

		return img;
	}

	__declspec(dllexport) int GetImageCount(dvr* d)
	{
		return d->idx;
	}

	__declspec(dllexport) int DeleteImage(dvr* d, int index)
	{
		if (index >= d->idx)
			return -1;
		for (int i=index; i<d->idx-1; i++)
			d->images[i] = d->images[i+1];
		d->idx --;
		
		d->images = (IMAGE*)realloc(d->images, sizeof(IMAGE) * d->idx);

		return 0;
	}

	__declspec(dllexport) int DeleteAllImages(dvr* d)
	{
		for (int i=0; i<d->idx; i++)
			free(d->images[i].ImageData);

		free(d->images);
		d->idx = 0;
		return 0;
	}

	__declspec(dllexport) bool Process(dvr* d, IMAGE* image, char inputPath[], char outputPath[], int newHeight, int newWidth, bool bw)
	{
		FILE *in, *out;

		fopen_s(&in, inputPath, "rb");
		fopen_s(&out, outputPath, "wb");

		if (in == NULL)
		{
			cout << "Error reading file";
			return false;
		}

		BITMAPFILEHEADER bfh;
		BITMAPINFOHEADER bih;

		fread(&bfh, sizeof(BITMAPFILEHEADER), 1, in);
		
		if (bfh.bfType != 0x4D42)
		{
			fclose(in);
			return false;
		}

		fread(&bih, sizeof(BITMAPINFOHEADER), 1, in);

		unsigned char *bitmapImageNew = (unsigned char*)malloc(newHeight*newWidth*3  * sizeof(unsigned char));

		double scaleWidth =  (double)newWidth / (double)image->Width;
		double scaleHeight = (double)newHeight / (double)image->Height;

		//
		for (unsigned int l = 0; l < newHeight; l++)
			for (unsigned int c = 0; c < newWidth; c++)
			{
				int pixel = (l * (newWidth *3)) + (c*3);
				int nearestMatch =  (((int)(l / scaleHeight) * (image->Width *3)) + ((int)(c / scaleWidth) *3) );
	            
				bitmapImageNew[pixel    ] =  image->ImageData[nearestMatch    ];
				bitmapImageNew[pixel + 1] =  image->ImageData[nearestMatch + 1];
				bitmapImageNew[pixel + 2] =  image->ImageData[nearestMatch + 2];

				if (bw == true)
				{
					unsigned char gray = bitmapImageNew[pixel] * 0.11 + bitmapImageNew[pixel+1] * 0.59 + bitmapImageNew[pixel+2] * 0.3;
					bitmapImageNew[pixel    ] =  gray;
					bitmapImageNew[pixel + 1] =  gray;
					bitmapImageNew[pixel + 2] =  gray;
				}
			}
		//
	
		// modify sizes
		bfh.bfSize -= bih.biSizeImage - newHeight*newWidth*3;

		bih.biSizeImage = newHeight*newWidth*3;
		bih.biHeight = newHeight;
		bih.biWidth = newWidth;

		// write in output file BITMAPFILEHEADER and BITMAPINFOHEADER
		fseek(out, 0, SEEK_SET);
		fwrite(&bfh, sizeof(BITMAPFILEHEADER), 1, out);
		fwrite(&bih, sizeof(BITMAPINFOHEADER), 1, out);

		// write in output file ImageData
		fseek(out, bfh.bfOffBits, SEEK_SET);
		fwrite(bitmapImageNew, bih.biSizeImage, 1, out);

		fclose(out);
		free(bitmapImageNew);

		return true;
	}
}

