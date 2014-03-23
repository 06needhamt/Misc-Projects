#include <iostream>
#include <chrono>
#include <thread>

#pragma once

int main(int argc, char* argv[])
{
	std::chrono::steady_clock::time_point before = std::chrono::steady_clock::now();
	std::this_thread::sleep_for(std::chrono::nanoseconds(1));
	//std::operator<<(std::cout, "Hello World \n");  //the supposedly faster one
	std::cout << "Hello World\n";					//the supposedly slower one
	//std::this_thread::sleep_for(std::chrono::nanoseconds(100));
	std::chrono::steady_clock::time_point after = std::chrono::steady_clock::now();
	std::chrono::steady_clock::duration time = after - before;
	std::cout << std::chrono::duration_cast<std::chrono::nanoseconds>(time).count() << std::endl;
	system("PAUSE");
	return 0;


}