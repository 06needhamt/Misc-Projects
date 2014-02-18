/*Files.h*/
#include <list>
#ifndef ofstream
//#include <stdio.h>
#include <fstream>
#else

#endif

#ifndef getline
#include <string>
#else

#endif

int WriteFile(void);
int ReadFile(void);

int WriteFile()
{
	std::ofstream myfile;
	myfile.open("example.txt");
	myfile << "Writing this to a file.\n";
	myfile.close();
	return 0;
}

int ReadFile()
{
	std::string line;
	std::string str = "End";
	std::ifstream myifile;
	/* std::list<std::string> mylist;
	std::list<std::string>::iterator it; */
	int i = 0;
	/* it = mylist.begin(); */
	myifile.open("example.txt");
	if (myifile.is_open())
	{
		while (getline(myifile, line))
		{
			std::cout << line << std::endl;
			/* mylist.push_back(line);
			mylist.push_back(str);
			++it; */
		}
	
	}
	return 0;
}
