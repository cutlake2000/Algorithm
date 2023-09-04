#include <stdio.h>
int main ()
{
	int a = 0, b = 0;
	scanf("%d %d", &a, &b);
	
	int three = a * (b % 10);
	int four = (a * (b%100 - b%10))/10;
	int five = a*(b/100);

	printf ("%d\n%d\n%d\n%d", three, four, five, three + 10*four + 100*five);
}