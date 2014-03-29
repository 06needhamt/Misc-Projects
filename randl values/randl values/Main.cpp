#include <iostream>
#include <string>
#include "MoreComplexExample.h"

#pragma once

/* This class shows the how you can create a class to accept rvalues and lvalue references 
*	through different constructors so you can treat them differently.
*/

/* What is the difference between and rvalue and an lvalue */

/* An rvalue is any valuer that is stored in a tempory location i.e a register 
*	Example rvalue 2 
*	the number 2 is stored ina register temorarily so that makes i a rvalue reference
*	but i can be converted to  an lvalue like this int j = 2 this creates an lvalue j from
*	the value of 2.
*/

/* An lvalue is any object that is not an rvalue  i.e a int k = 2 
*	k is an lvalue because it it stored in memory not in a register 	
*/

class somepointlessobject 
{
public:
	int pointlessinteger;
	std::string name;
public:
	somepointlessobject() { std::operator<<(std::cout, "A pointless object has been constructed \n"); pointlessinteger = 1; name = "Un-named"; } // zero parameter constructor
	somepointlessobject(int & lvalueref, std::string parname) { std::operator<<(std::cout, "A pointless object has been constructed With an lvalue reference \n"); pointlessinteger = lvalueref;  name = parname; }; // single parameter constructor that takes a int lvalue reference
	somepointlessobject(int && rvalueref, std::string parname) { std::operator<<(std::cout, "A pointless object has been constructed With an rvalue reference \n"); pointlessinteger = rvalueref; name = parname; }; // single parameter constructor that takes a int rvalue reference
	somepointlessobject(const somepointlessobject& rhs) // Copy Constructor
	{
		pointlessinteger = rhs.pointlessinteger;
		name = rhs.name;
	}
	~somepointlessobject() { std::operator<<(std::cout, "A pointless object has been destructed \n"); }

public:
	somepointlessobject* operator= (const somepointlessobject& rhs)  // copy Assignment operator
	{
		//delete this;
		somepointlessobject* p;
		p = new somepointlessobject(rhs);
		return p;

	}

};

int main2(int argc, char* argv[])
{
	int i = 1; // create an int lvalue i from the r value 1
	int& j = i; // create anb int lvalue reference from the lvalue i
	somepointlessobject* p = new somepointlessobject(); // create a somepointlessobject with no parameters
	std::cout << '\n';
	somepointlessobject* lp = new somepointlessobject(j,"Tom"); // create a somepointlessobject with an lvalue reference parameter
	//std::cout << '\n';
	std::cout << "lvalueref = " << lp->pointlessinteger << std::endl;
	std::cout << "lp's name = " << lp->name << std::endl;
	somepointlessobject* rp = new somepointlessobject(2,"Needham"); // create a somepointlessobject with an rvalue referenve parameter
	//std::cout << '\n';
	std::cout << "rvalueref = " << rp->pointlessinteger << std::endl;
	std::cout << "rp's name = " << rp->name << std::endl;
	delete p;
	delete lp;
	delete rp;
	p = nullptr;
	lp = nullptr;
	rp = nullptr;
	std::cout << testexample() << std::endl;

	system("PAUSE");
	return 0;
}