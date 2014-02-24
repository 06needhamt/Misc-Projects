#include <stdio.h>
#include <stdlib.h>

//void initialisearray (char* myarray, int nrows);

const int nrows = 3;
char* myarray [3];

void initialisearray (char* myarray, int nrows)
{
	
	int i;

	for (i = 0; i < nrows; i++)
	{
		myarray[i] = "and";
	    printf((const char *)myarray[i]);
		
	}
}

int main()
{
	initialisearray(*myarray,nrows);
	return 0;
}

