#include<stdio.h>
int main ()
{
	int N = 0, X = 0, A = 0;
	scanf ("%d %d", &N, &X);

	for (int i = 1; i <= N; i++)
	{
		scanf ("%d", &A);

		if (A < X)
		{
			printf ("%d ", A);
		}
	}
	return 0;
}