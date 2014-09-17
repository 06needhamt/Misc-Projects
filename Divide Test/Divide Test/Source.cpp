
int a = 10;
int b = 2;
int c = 0;

int asmdivide(void);

int main(int argc, char* argv[])
{
	asmdivide();
}

int asmdivide()
{
	__asm

	{
		push dword ptr[a]
		push dword ptr[b]
		pop edx
		pop eax
		idiv eax
		push ecx
		pop dword ptr[c]
	}
	return c;
}