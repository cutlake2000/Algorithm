#include <stdio.h>
#include <string.h>

int main ()
{
	int i, jump;
	int result = 0;
	char word[101] = {0,};
	scanf ("%s", word);
	int len = (int)strlen (word);


	for (i = 0; i < len;)
	{
		jump = 0;

		if (word[i] == 'c' && (word[i + 1] == '=' || word[i + 1] == '-')) jump = 2;

		else if (word[i] == 'd' && (word[i + 1] == 'z' && word[i + 2] == '=')) jump = 3;
		
		else if (word[i] == 'd' && (word[i + 1] == '-')) jump = 2;

		else if (word[i + 1] == 'j' && (word[i] == 'l' || word[i] == 'n')) jump = 2;

		else if (word[i + 1] == '=' && (word[i] == 's' || word[i] == 'z')) jump = 2;

		else if ('a' <= word[i] && word[i] <= 'z') jump = 1;

		if (jump > 0)
		{
			result++;
			i += jump;
		}
	}

	printf ("%d", result);
}