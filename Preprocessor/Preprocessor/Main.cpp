#define _SCL_SECURE_NO_WARNINGS 1
#include<iostream>
#include<string>
#include<fstream>
#include"vars.h"
//#include"Preprocessing.h"
#ifndef std::vector
#include <vector>
#else
#pragma warning Vector is already included
#endif // !std::vector



void OpenFile(void);
void include(void);
std::vector<std::string> split(void);
void writecontentsofincludedfile(std::string line);

int main(int argc, char* argv[])
{
	if (argc >= 3)
	{
		currentdirectory = argv[0];
		std::cout << argv[1] << std::endl;
		std::cout << argv[2] << std::endl;
		inputfile = argv[1];
		outputfile = argv[2];
		OpenFile();
		system("PAUSE");
		return 0;
	}
	else
	{
		std::cout << "Invalid Arguments" << std::endl;
		system("PAUSE");
		return -1;
	}
}

void OpenFile()
{
	
	inputstream.seekg(0, inputstream.end);
	std::cout << inputstream.tellg();
	inputstream.seekg(inputstream.beg, 0);
	inputstream.read(buffer, size);
	split();
	outputstream.write(buffer,size);
	delete[] buffer;
	outputstream.close();
	inputstream.close();
	std::cout << "Preprocessing is complete" << std::endl;
	return;

}

void writecontentsofincludedfile(std::string line)
{
	std::ifstream inputstream2;
	std::ofstream outputstream2;

	long size2 = line.size();
	char* aline = new char[size2];
	inputstream2.open(aline, 'r');
	inputstream.read(aline, size);
	inputstream2.seekg(inputstream2.beg, inputstream2.end);
	inputstream2.seekg(inputstream2.beg, 0);
	long sizeoffile = inputstream2.tellg();
	char* file = new char[sizeoffile];
	inputstream2.read(aline, sizeoffile);
	outputstream.open(inputfile, 'w');
	outputstream2.write(file, size);
	return;
}

std::vector <std::string> split()
{
	std::vector<std::string> elems;
	inputstream.read(buffer, 1);
	for (int i = 0; i < size; i++)
	{
		inputstream.read(&buffer[i], 1);
		if (buffer[i] == '#')
		{
			std::string line;

			const char delim = '\n';
			while (std::getline(inputstream.read(buffer, size), line, delim));
			{
				elems.push_back(line);
			}
			writecontentsofincludedfile(line);
		}
	}
	return elems;
}