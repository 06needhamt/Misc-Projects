#include <iostream>
#include <string>
#include <memory>
#include "Any.h"
#include "A.h"
int main(int argc, char* argv[])
{
	A* a = (A*)malloc(sizeof(A));
	std::cout << sizeof(A) << std::endl;
	//a = new A();
	a->num1 = 1;
	std::cout << a->num1 << std::endl;
	system("PAUSE");
	return 0;
}