#define _CRT_SECURE_NO_WARNINGS
#pragma warning (disable : 6031)
#include <stdio.h>

int main ()
{
	int A, B, C, checkNum, i;
	scanf ("%d\n%d\n%d", &A, &B, &C);
	int num[10] = { 0, };
	int result = A * B * C;

	while (result > 0)
	{
		checkNum = result % 10;
		num[checkNum]++;
		result /= 10;
	}

	for (i = 0; i < 10; i++)
	{
		printf ("%d\n", num[i]);
	}
}