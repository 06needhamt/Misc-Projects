// example.h

#ifndef test
#define test 

class Calculator
{
public:
	static void Run();
public:
	static double Add(double a , double b , double total);
public:
	static double Subtract(double a , double b , double total);
public:
	static double Multiply(double a , double b , double total);
public: 
	static double Divide(double a , double b , double total);
public:
	static double ParcelCalculator(double width , double length , double depth , double weight , double price); 
public:
	static bool Reset();
};

#endif

// end example.h

