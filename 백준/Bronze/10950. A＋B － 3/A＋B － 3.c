#include <stdio.h>
int main ()
{
	int testCase = 0, A = 0, B = 0;
	scanf ("%d", &testCase);
	
	for (int i = 1; i <= testCase; i++)
	{
		scanf ("%d %d", &A, &B);
		printf ("%d\n", A + B);
	}
	return 0;
}