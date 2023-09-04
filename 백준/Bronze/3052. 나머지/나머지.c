#define _CRT_SECURE_NO_WARNINGS
#pragma warning(disable : 6031)
#include <stdio.h>

int main ()
{
	int i, result;
	int checkNum = 0, count = 0;
	int num[42] = { 0, };

	for (i = 0; i < 10; i++)
	{
		scanf ("%d", &checkNum);
		result = checkNum % 42;
		num[result]++;
	}

	for (i = 0; i < 42; i++)
	{
		if (num[i] != 0)
		{
			count++;
		}
	}

	printf ("%d", count);
}