#include <stdio.h>
int main ()
{
	int H = 0, M = 0;
	scanf("%d %d", &H, &M);

	if (!(0 <= H && H <= 23) || !(0 <= M && M <= 59))
	{
		printf ("잘못된 시간입니다.");
		return 0;
	}
	else if (M >= 45)
	{
		M = M - 45;
	}
	else
	{
		if (H == 0)
		{
			H = 23;
		}
		else
		{
			H--;
		}
		M = 15 + M;
	}

	printf ("%d %d", H, M);
}