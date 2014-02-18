/* integers.h */

/*int integers::a = 0;
int integers::b = 0;
int integers::total = 0; */

class integers
{
	public:
		static int a;
	public:
		static int b;
	public:
		static int total;
		
	public:
		static void Run()
		{
			int choice = 0;
			std::cout << "Enter 1 for add" << std::endl;
			std::cout << "Enter 2 for subtract" << std::endl;
			std::cout << "Enter 3 for multiply" << std::endl;
			std::cout << "Enter 4 for divide" << std::endl;
			std::cin >> choice;
			
			switch(choice)
			{
				case 1:
				{
					integers::Add();
					if(integers::Again())
					{
						integers::Run();
					}
					else
					{
						system("PAUSE");
						break;
					}
				}
				case 2:
				{
					integers::Subtract();
					if(integers::Again())
					{
						integers::Run();
					}
					else
					{
						system("PAUSE");
						break;
					}
				}
				case 3:
				{
					integers::Multiply();
					if(integers::Again())
					{
						integers::Run();
					}
					else
					{
						system("PAUSE");
						break;
					}
				}
				case 4:
				{
					integers::Divide();
					if(integers::Again())
					{
						integers::Run();
					}
					else
					{
						system("PAUSE");
						break;
					}
				}
				default:
				{
					system("PAUSE");
					break;
				}
			}
		}
	
	public:
		static int Add()
		{
			std::cin >> integers::a;
			std::cin >> integers::b;
			integers::total = a + b;
			std::cout << integers::total << std::endl;
			return total;
		}
	public:
		static int Subtract()
		{
			std::cin >> integers::a;
			std::cin >> integers::b;
			integers::total = a - b;
			std::cout << integers::total << std::endl;
			return total;
		}
	public:
		static int Multiply()
		{
			std::cin >> integers::a;
			std::cin >> integers::b;
			integers::total = a * b;
			std::cout << integers::total << std::endl;
			return total;
		}
	public:
		static int Divide()
		{
			std::cin >> integers::a;
			std::cin >> integers::b;
			integers::total = a / b;
			std::cout << integers::total << std::endl;
			return total;
		}
	public:
		static bool Again()
		{
			int input;
			std::cin >> input;
			std::cout << input << std::endl;
			return input == 1 ? true : false;
		}
};

int integers::a = 0;
int integers::b = 0;
int integers::total = 0;
/*bool integers::reset = false;*/