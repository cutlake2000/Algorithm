#define _CRT_SECURE_NO_WARNINGS
#pragma warning(disable : 6031)
#include <stdio.h>

int main ()
{
	int sizeOfArray, i;
	float max = 0, sum = 0, average = 0;
	scanf ("%d", &sizeOfArray);
	float* array = NULL;
	
	array = malloc (sizeOfArray * sizeof (float));

	for (i = 0; i < sizeOfArray; i++)
	{
		scanf ("%f", &array[i]);

		if (array[i] > max)
		{
			max = array[i];
		}
	}

	for (i = 0; i < sizeOfArray; i++)
	{
		array[i] = array[i] / max * 100;
		sum += array[i];

	}

	average = sum / sizeOfArray;
	printf ("%f", average);
}