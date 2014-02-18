#include <iostream>
#include <stdio.h>
#include "numbers.h"
#include "integers.h"
#include "Files.h"

#define	AMOUNT 	5

void* AllocateMemory(void);
void TestStruct(void);

int main(int argc, char* argv[])
{
	std::cout << "Hello World" << std::endl;
	WriteFile();
	ReadFile();
	AllocateMemory();
	TestStruct();
	integers::Run();
	return 0;
}

void* AllocateMemory(void)
{
	void* ptr;
	ptr = nullptr;
	ptr = malloc(1024);
	if (ptr == nullptr)
	{
		std::cout << "ptr = null" << std::endl;
	}
	else
	{
		std::cout << ptr << std::endl;
		free(ptr);
		std::cout << "ptr has been freed" << std::endl;
	}
	return ptr;
}

void TestStruct(void)
{
	numbers* num = new numbers[AMOUNT];

	for (int i = num[0].zero; i < AMOUNT; i++)
	{
		//num[i].upper = 5;
		//num[i].lower = -5;
		while (num[i].lower < num[i].upper)
		{
			num[i].lower++;
			std::cout << num[i].lower << std::endl;
		}
		std::cout << num[i].lower << std::endl;
	}
	delete[] num;
}