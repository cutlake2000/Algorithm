#include <stdio.h>
int main ()
{
	int T = 0, A = 0 , B = 0;
	scanf ("%d", &T);

	for (int i = 1; i <= T; i++)
	{
		scanf ("%d %d", &A, &B);
		printf ("Case #%d: ", i);
		printf ("%d\n", A + B);
	}
	return 0;
}