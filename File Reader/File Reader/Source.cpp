#include <iostream>
#include <string>
#include <fstream>

int main(int argc, char* argv[])
{
	std::string filename;
	char userinput[512];
	std::string readbuffer;

	std::cout << "please enter the file name that you wish to output to" << std::endl;
	std::cin >> filename;
	std::cin.get();
	std::cout << "please enter text to save from the file" << std::endl;
	std::cin.getline(userinput, 512);
	std::cout << userinput << std::endl;
	std::ofstream* writetofile = new std::ofstream(filename);
	writetofile->open(filename);
	writetofile->write(userinput, 512);
	writetofile->close();
	//system("CLS");
	std::ifstream* readfromfile = new std::ifstream(filename);
	readfromfile->open(filename);
	if (readfromfile->is_open())
	{
		while (!readfromfile->eof())
		{
			std::getline(*readfromfile, readbuffer);
			std::cout << readbuffer << std::endl;
		}
		readfromfile->close();
	}
	system("PAUSE");
	return 0;
}