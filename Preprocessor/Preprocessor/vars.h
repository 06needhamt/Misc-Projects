/* vars.h */
#ifndef vars
#define vars
#ifndef std::string
#include <string>
#else
#pragma warning "String is already included"
#endif
#ifndef std::ifstream || std::ofstream
#include<fstream>
#else
#pragma warning "fstream is aready included"
#endif

std::string inputfile;
std::string outputfile;
std::string currentdirectory;
std::ifstream inputstream;
std::ofstream outputstream;
long size = inputstream.tellg();
char* buffer = new char[size];
//char* buffer[1];

#endif