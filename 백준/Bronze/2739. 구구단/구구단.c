#include <stdio.h>
int main ()
{
	int ggd = 0;
	scanf("%d", &ggd);

	for (int i = 1; i <= 9; i++)
	{
		printf ("%d * %d = %d\n", ggd, i, ggd * i);
	}
	return 0;
}