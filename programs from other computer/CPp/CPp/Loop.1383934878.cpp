#include <iostream>
//#include <boost/throw_exception.hpp>
int t = 11;

void throwException(int i) throw (std::exception);
int main(int argc , char** argv)
{
	
	char c = NULL;
	while(t-- != -11)
	{
		std::cout << t <<std::endl;
		throwException(t);
	}

	std::cin >> c;
	return 0;
}

void throwException(int i) throw (std::exception)
{
	if (t != 10)
	{
		try
		{
			throw new std::exception;
		}
		catch (std::exception ex)
		{
			std::cout << ex.what();
		}
	}
}
