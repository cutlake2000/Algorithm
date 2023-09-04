#include <stdio.h>
#include <stdlib.h>

int main ()
{
	int SizeOfArray, input, i;
	int max = 0, min = 0;
	int* num = NULL;

	scanf("%d", &SizeOfArray);
	
	if (1 <= SizeOfArray && SizeOfArray <= 1000000)
	{
		num = malloc (SizeOfArray * sizeof (int));

		for (i = 0; i < SizeOfArray; i++)
		{
			scanf("%d", &input);
			
			if (num != NULL)
			{
				num[i] = input;

				if (i == 0)
					min = max = num[i];
				else if (num[i] > max)
					max = num[i];
				else if (min > num[i])
					min = num[i];
			}

		}
		printf ("%d %d", min, max);
	}
	free (num);
	return 0;
}