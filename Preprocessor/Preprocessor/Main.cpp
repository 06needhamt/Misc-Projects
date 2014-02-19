#define _SCL_SECURE_NO_WARNINGS 1
#include<iostream>
#include<string>
#include<fstream>
#include"vars.h"

void includepreprocess(void);
int main(int argc, char* argv[])
{
	if (argc >= 3)
	{
		currentdirectory = argv[0];
		std::cout << argv[1] << std::endl;
		std::cout << argv[2] << std::endl;
		inputfile = argv[1];
		outputfile = argv[2];
		includepreprocess();
	}
	else
	{
		std::cout << "Invalid Arguments" << std::endl;
		system("PAUSE");
		return -1;
	}
	return 0;
}

void includepreprocess()
{
	
	inputstream.seekg(0, inputstream.end);
	inputstream.seekg(inputstream.beg,0);
	long long size = inputstream.tellg();
	char* buffer = new char[size];
	inputstream.read(buffer, size);
	outputstream.write(buffer,size);
	delete[] buffer;
	outputstream.close();
	inputstream.close();
	return;

}