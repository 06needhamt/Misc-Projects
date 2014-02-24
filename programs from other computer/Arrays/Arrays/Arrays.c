#include <stdio.h>
#include <stdlib.h>

void initialisearray (char *array, int nrows, int ncolumns);

	int nrows = 50;
	int ncolumns = 50;
	char *myarray = NULL;
	int i;
	int j;



void initialisearray (char *array, int nrows, int ncolumns)
{
	
	for (i = 0; i < nrows; i++)
	{
		for (j = 0; j < ncolumns; j++)
		{
			myarray[i][j] = 'a';
			printf((const char *)myarray[i][j]);
		}
	}
}

int main()
{
	initialisearray(myarray,nrows,ncolumns);
	return 0;
}

