/* Header File */

/* How to use inline assembly to manipulatre non rvalues*/
#pragma once
#ifndef MORE_COMPLEX_EXAMPLE
#define MORE_COMPLEX_EXAMPLE 

#ifndef std::cout
#include <iostream>
#else
#pragma warning push "<IOSTREAM> IS ALREADY INCLUDED"
#endif // std::cout

#ifndef std::string
#include <string>
#else
#pragma warning push "<STRING> IS ALREADY INCLUDED"
#endif // std::string



 

class mylvalue 
{
public:
	int sum;
public:
	mylvalue() { sum = 0; }

public:
	int& somepointlesscalculation(int& i, int && j)
	{
		
		std::cout << "i = " << i << std::endl;
		std::cout << "i = " << i << std::endl;
		__asm
		{
			mov eax,j
			mov ecx,i
			add eax,ecx
			mov eax,sum 
			
			
		}
		std::cout << sum << std::endl;
		return sum;
	}
};


int& testexample()
{
	mylvalue* mlv = new mylvalue();
	int j = 5;
	int i = j;
	int& retval = mlv->somepointlesscalculation(i, 5);
	//std::cout << retval << std::endl;
	return retval;

}
#endif // MORE_COMPLEX_EXAMPLE


