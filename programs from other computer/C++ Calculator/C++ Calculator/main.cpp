// Main.cpp

#include <iostream>
#include <stdio.h>
#include <exception>
#include "example.h"

int main()
{
	Calculator::Run();
	return 0;
}

void Calculator::Run()
{
	int choice = NULL;
	std::cout << "Enter 1 for add" <<std::endl;
	std::cout << "Enter 2 for subtract" <<std::endl;
	std::cout << "Enter 3 for multiply" <<std::endl;
	std::cout << "Enter 4 for divide" <<std::endl;
	std::cout << "Enter 5 for parcel calculator" <<std::endl;
	std::cout << "Enter anything else to quit" <<std::endl;

	std::cin >> choice;

	switch (choice)
	{
	case 1:
			Calculator::Add(0,0,0);
			break;
	case 2:
			Calculator::Subtract(0,0,0);
			break;
	case 3:
			Calculator::Multiply(0,0,0);
			break;
	case 4:
			Calculator::Divide(0,0,0);
			break;
	case 5:
			Calculator::ParcelCalculator(0,0,0,0,0);
			break;
	default:
			exit(0);
			break;


	}
}

double Calculator::Add(double a , double b, double total)
{
	std::cout << "Enter first number" <<std::endl;
	std::cin >> a;
	std::cout << "Enter second number" <<std::endl;
	std::cin >> b;
	total = a + b;
	std::cout << total <<std::endl;
	Calculator::Reset();
	return total;

}

double Calculator::Divide(double a , double b, double total)
{
	std::cout << "Enter first number" <<std::endl;
	std::cin >> a;
	std::cout << "Enter second number" <<std::endl;
	std::cin >> b;
	total = a / b;
	std::cout << total <<std::endl;
	Calculator::Reset();
	return total;

}

double Calculator::Multiply(double a , double b, double total)
{
	std::cout << "Enter first number" <<std::endl;
	std::cin >> a;
	std::cout << "Enter second number" <<std::endl;
	std::cin >> b;
	total = a * b;
	std::cout << total <<std::endl;
	Calculator::Reset();
	return total;

}
double Calculator::Subtract(double a , double b, double total)
{
	std::cout << "Enter first number" <<std::endl;
	std::cin >> a;
	std::cout << "Enter second number" <<std::endl;
	std::cin >> b;
	total = a - b;
	std::cout << total <<std::endl;
	Calculator::Reset();
	return total;

}

double Calculator::ParcelCalculator(double width , double length , double depth , double weight , double price)
{
	std::cout << "Enter Parcel Width" << std::endl;
	std::cin >> width;
	std::cout << "Enter Parcel length" << std::endl;
	std::cin >> length;
	std::cout << "Enter Parcel depth" << std::endl;
	std::cin >> depth;
	std::cout << "Enter Parcel weight" << std::endl;
	std::cin >> weight;

	if (width <= 16.0 || length <= 16.0 || depth <= 16.0 || weight <= 2000)
	{
		price = 3.69;
		std::cout << price <<std::endl;
	}
	else if (width <= 32.0 || length <= 32.0 || depth <= 12.0 || weight <= 10000)
	{
		price = 5.49;
		std::cout << price <<std::endl;
	}
	else if (width > 32.0 || length > 32.0 || depth > 32.0 || weight > 10000)
	{
		price = 7.99;
		std::cout << price <<std::endl;
	}
	Calculator::Reset();

	return price;
}

bool Calculator::Reset()
{
	bool again = false;
	int input = NULL;

	std::cout << "Do you want to perform another calculation?" <<std::endl;
	std::cout << "Enter 1 for yes" <<std::endl;
	std::cout << "Enter 0 for no" <<std::endl;
	std::cin >> input;

	switch (input)
	{
	case 0:
			again = false;
			break;
	case 1:
			again = true;
			break;
	default:
			again = false;
			break;
	}
	
	if (again == true)
	{
		Calculator::Run();
	}
	else
	{
		exit(0);
	}
	return again;
}
//end Main.cpp

