#include <stdio.h>
int main ()
{
	int num = 0, checkNum = 0, cycle = 0;
	scanf("%d", &num);

	if (0 <= num && num <= 99)
	{
		checkNum = num;
		do
		{
			num = (((num / 10) + (num % 10)) % 10) + (num % 10) * 10;
			cycle++;
		} while (num != checkNum);

		printf ("%d", cycle);
	}
	return 0;
}