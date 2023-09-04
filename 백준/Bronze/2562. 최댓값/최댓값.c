#define _CRT_SECURE_NO_WARNINGS
#pragma warning(disable : 6031)
#include <stdio.h>
int main ()
{
	int max = 0, count = 0, input, i;
	int num[9] = { 0, };

	for (i = 0; i < 9; i++)
	{
		scanf ("%d", &num[i]);

		if (num[i] >= max)
		{
			max = num[i];
			count = i + 1;
		}
	}
	printf ("%d\n%d", max, count);
	return 0;
}