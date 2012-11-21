#include <stdio.h>
#include <fstream>
#include <iostream>

#include <winsock2.h>
#pragma comment(lib,"Ws2_32.lib")

using namespace std;

typedef struct {
	int Width;
	int Height;
	int BitCount;
	int Format;
	int ByteArrayLen;
	char * ImageData;
} IMAGE;
