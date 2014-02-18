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
	std::copy(line.begin(), line.end(), cline);
	cline[line.size() + 1] = '\0';
	while (getline(inputstream, line))
	{
		outputstream.write(cline, 'w');
	}
	delete[] cline;

}