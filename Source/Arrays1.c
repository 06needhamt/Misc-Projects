/*
GCC output
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
f
g
h
i
j
k
l
m
n
o
p
q
r
s
t
u
v
w
x
y
z
{
|
}
~
⌂
Ç
ü
é
â
ä
à
å
ç
ê
ë
è
ï
î
ì
Ä
Å
É
æ
Æ
ô
ö
ò
û
ù
Press any key to continue . . .*/

/* cl output

00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
00000041
x
y
z
{
|
}
~
⌂
Ç
ü
é
â
ä
à
å
ç
ê
ë
è
ï
î
ì
Ä
Å
É
æ
Æ
ô
ö
ò
û
ù
ÿ
Ö
Ü
ø
£
Ø
×
ƒ
á
í
ó
ú
ñ
Ñ
ª
º
¿
®
Press any key to continue . . . */

#include <stdio.h>
#include <stdlib.h>

#define nrows 50

void Array(void);

int main(int argc, char* argv)
{
	Array();
	/*Array(void);  is needed for the cl.exe compiler because it is crap */
	system("pause");
	return 0;

}

void Array(void)
{
	//const int nrows = 50;
	char myarray[nrows];
	char* myparray[nrows];
	int i;
	int j;

	for (i = 0; i < nrows; i++)
	{
		myparray[i] = (char*)malloc(sizeof(char));
		myparray[i] = (char*) 'A';
		printf("%p", myparray[i]);
		printf("%s", "\n");
	}

	for (j = 0; j < nrows; j++)
	{
		myarray[j] = &myarray[j];
		printf("%c", myarray[j]);
		printf("%s", "\n");
	}

	return;

}