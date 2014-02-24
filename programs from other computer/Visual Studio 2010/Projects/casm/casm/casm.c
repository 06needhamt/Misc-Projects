#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>

#if defined(__STDC__)
# define PREDEF_STANDARD_C_1989
#	if defined(__STDC_VERSION__)
#  define PREDEF_STANDARD_C_1990
#  if (__STDC_VERSION__ >= 199409L)
#   define PREDEF_STANDARD_C_1994
#  endif
#  if (__STDC_VERSION__ >= 199901L)
#   define PREDEF_STANDARD_C_1999
#  endif
# endif
#endif

void asmtest(void);
void malloctest(void);
//void cpuidprintname(void);

int main (int argc, char* argv[])
{
	asmtest();
	printf("%s","asm is supported\n");
	malloctest();
	printf("%s","malloc is supported\n");
	return 0;
}

void asmtest(void)
{
	int x = 0;
	printf("%s","Testing if asm is supported\n");

	__asm
	{
		start:
		mov eax,10
		add eax,10
		mov ebx,0
		mov x,1
		cmp x,1
		je end
		push ebx
		cmp eax,20
		je looper
		xor eax,eax
		
		looper:
		mov ecx,10000000000000
		inc ebx
		cmp ebx,ecx
		jne looper
		pop ebx
		xor ebx,ebx
		
		end:
		xor eax,eax
		
	};
	printf("%d", x);
	printf("%s", "\n");
}

void malloctest(void)
{
	int size = 1024;
	int i = 0;
	int j = 0;
	void* p = '\0';
	int* ip = (int*) malloc(16);
	printf("%s" "Testing if malloc is suppoted\n");
	if (size > sizeof(int))
	{
		p = malloc(size);
		printf("%s", p);
		printf("%s", "\n");
	}
	
	for (i = 0; i <= 10; i++)
	{
		ip[i] = i;
		printf("%d", ip[i]);
		printf("%s", "\n");
	}
	
	if (p != NULL)
	{
		printf("%s", "Freeing p\n");
		free(p);
		printf("%s", "p has been freed\n");
	}
	
	if (ip != NULL)
	{
		printf("%s", "freeing ip \n");
		for (j = 0; j < 9; j++)
		{
			free((void*)ip[j]);
			ip[j] = NULL;
		}

		
		printf("%s", "ip has been freed\n");
	}
	scanf("%s");
}
