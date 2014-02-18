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
	/*const char* cinputfile = inputfile; */
	std::string line;

	char* cline = new char[line.size() + 1];
	inputstream.open(inputfile, 'r');
	outputstream.open(outputfile, 'w');
	//std::copy(line.begin(), line.end(), cline);
	//cline[line.size() + 1] = '\0';
	while (getline(inputstream, line))
	{
		std::copy(line.begin(), line.end(), cline);
		std::cout << cline << std::endl;
		outputstream.write(cline, 'w');
	}
	inputstream.close();
	outputstream.close();
	system("PAUSE");
	delete[] cline;

}