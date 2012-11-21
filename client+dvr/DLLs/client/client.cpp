#include "client.h"

class client
{
	public:
		// attributes
		int shape;
		int resCamX[16];
		int resCamY[16];
		int resMonitorX;
		int resMonitorY;
		char ** IPs;
		int * ports;
		SOCKET sock;

		// client methods
		bool SetShape(int);
		int GetShape();
		bool CalculateRes();
		bool SetResCamX(int, int);
		int GetResX(int);
		bool SetResCamY(int, int);
		int GetResY(int);
		bool SetResMonitorX(int);
		bool SetResMonitorY(int);

		bool Connect(char*, int);
		bool SendRes(int, int, int);
		bool SendBWCam(int, int);

		// delete them
		void GetResMonitorX(client* c);
		void GetResMonitorY(client* c);
};

extern "C"
{
	// useful methods
	__declspec(dllexport) client* createClient()
	{
		return new client();
	}



	__declspec(dllexport) bool SetShape(client* c, int shape)
	{
		c->shape = shape;
		if (c->shape == shape)
			return true;
		return false;
	}



	__declspec(dllexport) bool CalculateRes(client* c)
	{
		for (int i=0; i<16; i++)
		{
			c->resCamX[i] = -1;
			c->resCamY[i] = -1;
		}
		
		switch (c->shape)
		{
		case 0:
			c->resCamX[0] = c->resMonitorX;
			c->resCamY[0] = c->resMonitorY;
			break;

		case 1:
			c->resCamX[0] = c->resMonitorX;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX;
			c->resCamY[1] = c->resMonitorY / 2;

			break;

		case 2:
			c->resCamX[0] = c->resMonitorX;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX / 2;
			c->resCamY[1] = c->resMonitorY / 2;

			c->resCamX[2] = c->resMonitorX / 2;
			c->resCamY[2] = c->resMonitorY / 2;

			break;

		case 3:
			c->resCamX[0] = c->resMonitorX / 2;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX / 2;
			c->resCamY[1] = c->resMonitorY / 2;

			c->resCamX[2] = c->resMonitorX;
			c->resCamY[2] = c->resMonitorY / 2;

			break;

		case 4:
			c->resCamX[0] = c->resMonitorX;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX / 2;
			c->resCamY[5] = c->resMonitorY / 2;

			break;

		case 5:
			c->resCamX[0] = c->resMonitorX;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX / 2;
			c->resCamY[1] = c->resMonitorY / 2;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX / 4;
			c->resCamY[5] = c->resMonitorY / 4;

			break;

		case 6:
			c->resCamX[0] = c->resMonitorX;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX / 4;
			c->resCamY[5] = c->resMonitorY / 4;

			c->resCamX[6] = c->resMonitorX / 4;
			c->resCamY[6] = c->resMonitorY / 4;

			c->resCamX[7] = c->resMonitorX / 4;
			c->resCamY[7] = c->resMonitorY / 4;

			c->resCamX[8] = c->resMonitorX / 4;
			c->resCamY[8] = c->resMonitorY / 4;

			break;

		case 7:
			c->resCamX[0] = c->resMonitorX / 4;
			c->resCamY[0] = c->resMonitorY / 4;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 2;
			c->resCamY[4] = c->resMonitorY / 2;

			c->resCamX[5] = c->resMonitorX;
			c->resCamY[5] = c->resMonitorY / 2;

			break;

		case 8:
			c->resCamX[0] = c->resMonitorX / 2;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX;
			c->resCamY[5] = c->resMonitorY / 2;
	
			break;

		case 9:
			c->resCamX[0] = c->resMonitorX / 4;
			c->resCamY[0] = c->resMonitorY / 4;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX / 4;
			c->resCamY[5] = c->resMonitorY / 4;

			c->resCamX[6] = c->resMonitorX / 4;
			c->resCamY[6] = c->resMonitorY / 4;

			c->resCamX[7] = c->resMonitorX / 4;
			c->resCamY[7] = c->resMonitorY / 4;

			c->resCamX[8] = c->resMonitorX;
			c->resCamY[8] = c->resMonitorY / 2;
			break;

		case 10:
			c->resCamX[0] = c->resMonitorX / 2;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX / 2;
			c->resCamY[1] = c->resMonitorY / 2;

			c->resCamX[2] = c->resMonitorX / 2;
			c->resCamY[2] = c->resMonitorY / 2;

			c->resCamX[3] = c->resMonitorX / 2;
			c->resCamY[3] = c->resMonitorY / 2;
			break;

		case 11:
			c->resCamX[0] = c->resMonitorX / 4;
			c->resCamY[0] = c->resMonitorY / 4;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 2;
			c->resCamY[4] = c->resMonitorY / 2;

			c->resCamX[5] = c->resMonitorX / 2;
			c->resCamY[5] = c->resMonitorY / 2;

			c->resCamX[6] = c->resMonitorX / 2;
			c->resCamY[6] = c->resMonitorY / 2;
			break;

		case 12:
			c->resCamX[0] = c->resMonitorX / 2;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX / 2;
			c->resCamY[5] = c->resMonitorY / 2;

			c->resCamX[6] = c->resMonitorX / 2;
			c->resCamY[6] = c->resMonitorY / 2;
			break;

		case 13:
			c->resCamX[0] = c->resMonitorX / 2;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX / 2;
			c->resCamY[1] = c->resMonitorY / 2;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX / 4;
			c->resCamY[5] = c->resMonitorY / 4;

			c->resCamX[6] = c->resMonitorX / 2;
			c->resCamY[6] = c->resMonitorY / 2;
			break;

		case 14:
			c->resCamX[0] = c->resMonitorX / 2;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX / 2;
			c->resCamY[1] = c->resMonitorY / 2;

			c->resCamX[2] = c->resMonitorX / 2;
			c->resCamY[2] = c->resMonitorY / 2;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX / 4;
			c->resCamY[5] = c->resMonitorY / 4;

			c->resCamX[6] = c->resMonitorX / 4;
			c->resCamY[6] = c->resMonitorY / 4;
			break;

		case 15:
			c->resCamX[0] = c->resMonitorX / 4;
			c->resCamY[0] = c->resMonitorY / 4;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX / 4;
			c->resCamY[5] = c->resMonitorY / 4;

			c->resCamX[6] = c->resMonitorX / 4;
			c->resCamY[6] = c->resMonitorY / 4;

			c->resCamX[7] = c->resMonitorX / 4;
			c->resCamY[7] = c->resMonitorY / 4;

			c->resCamX[8] = c->resMonitorX / 2;
			c->resCamY[8] = c->resMonitorY / 2;

			c->resCamX[9] = c->resMonitorX / 2;
			c->resCamY[9] = c->resMonitorY / 2;
			break;

		case 16:
			c->resCamX[0] = c->resMonitorX / 4;
			c->resCamY[0] = c->resMonitorY / 4;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 2;
			c->resCamY[4] = c->resMonitorY / 2;

			c->resCamX[5] = c->resMonitorX / 4;
			c->resCamY[5] = c->resMonitorY / 4;

			c->resCamX[6] = c->resMonitorX / 4;
			c->resCamY[6] = c->resMonitorY / 4;

			c->resCamX[7] = c->resMonitorX / 4;
			c->resCamY[7] = c->resMonitorY / 4;

			c->resCamX[8] = c->resMonitorX / 4;
			c->resCamY[8] = c->resMonitorY / 4;

			c->resCamX[9] = c->resMonitorX / 2;
			c->resCamY[9] = c->resMonitorY / 2;
			break;

		case 17:
			c->resCamX[0] = c->resMonitorX / 4;
			c->resCamY[0] = c->resMonitorY / 4;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;
			
			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 2;
			c->resCamY[4] = c->resMonitorY / 2;

			c->resCamX[5] = c->resMonitorX / 2;
			c->resCamY[5] = c->resMonitorY / 2;

			c->resCamX[6] = c->resMonitorX / 4;
			c->resCamY[6] = c->resMonitorY / 4;

			c->resCamX[7] = c->resMonitorX / 4;
			c->resCamY[7] = c->resMonitorY / 4;

			c->resCamX[8] = c->resMonitorX / 4;
			c->resCamY[8] = c->resMonitorY / 4;

			c->resCamX[9] = c->resMonitorX / 4;
			c->resCamY[9] = c->resMonitorY / 4;
			break;

		case 18:
			c->resCamX[0] = c->resMonitorX / 2;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX / 4;
			c->resCamY[5] = c->resMonitorY / 4;

			c->resCamX[6] = c->resMonitorX / 4;
			c->resCamY[6] = c->resMonitorY / 4;

			c->resCamX[7] = c->resMonitorX / 4;
			c->resCamY[7] = c->resMonitorY / 4;

			c->resCamX[8] = c->resMonitorX / 4;
			c->resCamY[8] = c->resMonitorY / 4;

			c->resCamX[9] = c->resMonitorX / 2;
			c->resCamY[9] = c->resMonitorY / 2;
			break;

		case 19:
			c->resCamX[0] = c->resMonitorX / 2;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX / 2;
			c->resCamY[5] = c->resMonitorY / 2;

			c->resCamX[6] = c->resMonitorX / 4;
			c->resCamY[6] = c->resMonitorY / 4;

			c->resCamX[7] = c->resMonitorX / 4;
			c->resCamY[7] = c->resMonitorY / 4;

			c->resCamX[8] = c->resMonitorX / 4;
			c->resCamY[8] = c->resMonitorY / 4;

			c->resCamX[9] = c->resMonitorX / 4;
			c->resCamY[9] = c->resMonitorY / 4;
			break;

		case 20:
			c->resCamX[0] = c->resMonitorX / 2;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX / 2;
			c->resCamY[1] = c->resMonitorY / 2;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX / 4;
			c->resCamY[5] = c->resMonitorY / 4;

			c->resCamX[6] = c->resMonitorX / 4;
			c->resCamY[6] = c->resMonitorY / 4;

			c->resCamX[7] = c->resMonitorX / 4;
			c->resCamY[7] = c->resMonitorY / 4;

			c->resCamX[8] = c->resMonitorX / 4;
			c->resCamY[8] = c->resMonitorY / 4;

			c->resCamX[9] = c->resMonitorX / 4;
			c->resCamY[9] = c->resMonitorY / 4;
			break;

		case 21:
			c->resCamX[0] = c->resMonitorX / 4;
			c->resCamY[0] = c->resMonitorY / 4;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;
			
			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX / 4;
			c->resCamY[5] = c->resMonitorY / 4;

			c->resCamX[6] = c->resMonitorX / 4;
			c->resCamY[6] = c->resMonitorY / 4;

			c->resCamX[7] = c->resMonitorX / 4;
			c->resCamY[7] = c->resMonitorY / 4;

			c->resCamX[8] = c->resMonitorX / 4;
			c->resCamY[8] = c->resMonitorY / 4;

			c->resCamX[9] = c->resMonitorX / 4;
			c->resCamY[9] = c->resMonitorY / 4;

			c->resCamX[10] = c->resMonitorX / 4;
			c->resCamY[10] = c->resMonitorY / 4;

			c->resCamX[11] = c->resMonitorX / 4;
			c->resCamY[11] = c->resMonitorY / 4;

			c->resCamX[12] = c->resMonitorX / 2;
			c->resCamY[12] = c->resMonitorY / 2;
			break;

		case 22:
			c->resCamX[0] = c->resMonitorX / 4;
			c->resCamY[0] = c->resMonitorY / 4;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX / 4;
			c->resCamY[5] = c->resMonitorY / 4;

			c->resCamX[6] = c->resMonitorX / 4;
			c->resCamY[6] = c->resMonitorY / 4;

			c->resCamX[7] = c->resMonitorX / 4;
			c->resCamY[7] = c->resMonitorY / 4;

			c->resCamX[8] = c->resMonitorX / 2;
			c->resCamY[8] = c->resMonitorY / 2;

			c->resCamX[9] = c->resMonitorX / 4;
			c->resCamY[9] = c->resMonitorY / 4;

			c->resCamX[10] = c->resMonitorX / 4;
			c->resCamY[10] = c->resMonitorY / 4;

			c->resCamX[11] = c->resMonitorX / 4;
			c->resCamY[11] = c->resMonitorY / 4;

			c->resCamX[12] = c->resMonitorX / 4;
			c->resCamY[12] = c->resMonitorY / 4;
			break;
			
		case 23:
			c->resCamX[0] = c->resMonitorX / 2;
			c->resCamY[0] = c->resMonitorY / 2;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 4;
			c->resCamY[4] = c->resMonitorY / 4;

			c->resCamX[5] = c->resMonitorX / 4;
			c->resCamY[5] = c->resMonitorY / 4;

			c->resCamX[6] = c->resMonitorX / 4;
			c->resCamY[6] = c->resMonitorY / 4;

			c->resCamX[7] = c->resMonitorX / 4;
			c->resCamY[7] = c->resMonitorY / 4;

			c->resCamX[8] = c->resMonitorX / 4;
			c->resCamY[8] = c->resMonitorY / 4;

			c->resCamX[9] = c->resMonitorX / 4;
			c->resCamY[9] = c->resMonitorY / 4;

			c->resCamX[10] = c->resMonitorX / 4;
			c->resCamY[10] = c->resMonitorY / 4;

			c->resCamX[11] = c->resMonitorX / 4;
			c->resCamY[11] = c->resMonitorY / 4;

			c->resCamX[12] = c->resMonitorX / 4;
			c->resCamY[12] = c->resMonitorY / 4;
			break;

		case 24:
			c->resCamX[0] = c->resMonitorX / 4;
			c->resCamY[0] = c->resMonitorY / 4;

			c->resCamX[1] = c->resMonitorX / 4;
			c->resCamY[1] = c->resMonitorY / 4;

			c->resCamX[2] = c->resMonitorX / 4;
			c->resCamY[2] = c->resMonitorY / 4;

			c->resCamX[3] = c->resMonitorX / 4;
			c->resCamY[3] = c->resMonitorY / 4;

			c->resCamX[4] = c->resMonitorX / 2;
			c->resCamY[4] = c->resMonitorY / 2;

			c->resCamX[5] = c->resMonitorX / 4;
			c->resCamY[5] = c->resMonitorY / 4;

			c->resCamX[6] = c->resMonitorX / 4;
			c->resCamY[6] = c->resMonitorY / 4;

			c->resCamX[7] = c->resMonitorX / 4;
			c->resCamY[7] = c->resMonitorY / 4;

			c->resCamX[8] = c->resMonitorX / 4;
			c->resCamY[8] = c->resMonitorY / 4;

			c->resCamX[9] = c->resMonitorX / 4;
			c->resCamY[9] = c->resMonitorY / 4;

			c->resCamX[10] = c->resMonitorX / 4;
			c->resCamY[10] = c->resMonitorY / 4;

			c->resCamX[11] = c->resMonitorX / 4;
			c->resCamY[11] = c->resMonitorY / 4;

			c->resCamX[12] = c->resMonitorX / 4;
			c->resCamY[12] = c->resMonitorY / 4;
			break;

		case 25:
			for (int i=0; i<16; i++)
			{
				c->resCamX[i] = c->resMonitorX / 4;
				c->resCamY[i] = c->resMonitorY / 4;
			}
			break;
		
		default:
			return false;
		}
		return true;
	}



	__declspec(dllexport) bool SetResCamX(client* c, int cam, int value)
	{
		c->resCamX[cam] = value;
		if (c->resCamX[cam] == value)
			return true;
		return false;
	}

	__declspec(dllexport) bool SetResCamY(client* c, int cam, int value)
	{
		c->resCamY[cam] = value;
		if (c->resCamY[cam] == value)
			return true;
		return false;
	}

	__declspec(dllexport) bool SetResMonitorX(client* c, int res)
	{
		c->resMonitorX = res;
		if (c->resMonitorX == res)
			return true;
		return false;
	}
	__declspec(dllexport) bool SetResMonitorY(client* c, int res)
	{
		c->resMonitorY = res;
		if (c->resMonitorY == res)
			return true;
		return false;
	}
	__declspec(dllexport) int GetShape(client* c)
	{
		return c->shape;
	}

	__declspec(dllexport) int GetResX(client* c, int cam)
	{
		return c->resCamX[cam];
	}

	__declspec(dllexport) int GetResY(client* c, int cam)
	{
		return c->resCamY[cam];
	}
	




	__declspec(dllexport) bool Connect(client* c)
	{
		
		SOCKET client = INVALID_SOCKET;
		WSADATA wsaData;
		sockaddr_in local;
		int ret; 
		hostent *localHost;
		char* localIP;

		int wsaret=WSAStartup(0x101,&wsaData);
	    if(wsaret!=0)
			return false;
    
		client = socket(AF_INET,SOCK_STREAM,0);

		localHost = gethostbyname("");
		localIP = inet_ntoa (*(struct in_addr *)*localHost->h_addr_list);

		local.sin_family		= AF_INET; //Address family
		local.sin_addr.s_addr	= inet_addr(localIP);
		local.sin_port			= htons((u_short)20248); //port to use
		
		if (ret = connect(client, (struct sockaddr*)&local,sizeof(local)) < 0)
			return false;
		
		char buf[512];
		recv(client, buf, 2, 0);
		
		c->sock = client;

		return true;
	}

	__declspec(dllexport) char SendRes(client* c, int resY, int resX)
	{
		char rY[10];
		_itoa_s(resY, rY, 10);

		char rX[10];
		_itoa_s(resX, rX, 10);

		if (send(c->sock, rY, 10*sizeof(char), 0) <= 0)
			return false;
		if (send(c->sock, rX, 10*sizeof(char), 0) <= 0)
			return false;

		return rX[0];
	}

	__declspec(dllexport) char SendBWCam(client* c, int b, int cam)
	{
		char bch[10];
		_itoa_s(b, bch, 10);

		char camch[10];
		_itoa_s(cam, camch, 10);

		if (send(c->sock, bch, 10*sizeof(char), 0) <= 0)
			return -1;
		if (send(c->sock, camch, 10*sizeof(char), 0) <= 0)
			return -1;

		return camch[0];
	}

	__declspec(dllexport) bool CloseConnection(client* c)
	{
		int ret = closesocket(c->sock);
	    WSACleanup();
		if (ret != 0)
			return false;
		return true;
	}

}
	

	