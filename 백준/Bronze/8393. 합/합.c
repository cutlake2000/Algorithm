#include <stdio.h>
int main ()
{
	int n = 0, sum = 0;
	scanf("%d", &n);
	
	if (1 <= n && n <= 10000)
	{
		for (int i = 1 ; i <= n ; i++)
		{
			sum = sum + i;
		}
		printf ("%d", sum);
	}
	else
	{
		printf ("잘못된 입력입니다.");
	}
}