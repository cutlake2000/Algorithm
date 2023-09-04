#include <stdio.h>
#include <string.h>

int word_Checker ()
{
    int i, len, check_Alphabet;
    int now = 0, result = 1;
    char word[101] = { 0, };
    char alphabet[26] = { 0, };

    scanf ("%s", word);

    for (i = 0, len = (int)strlen (word); i < len; i++)
    {
        check_Alphabet = alphabet[word[i] - 97];
        if (check_Alphabet == 0) alphabet[word[i] - 97]++;
        else if ((check_Alphabet > 0) && (word[i] != word[i - 1])) result = 0;
    }

    return result;
}

int main ()
{
    int i;
    int input = 0, result = 0;
    scanf ("%d", &input);

    for (i = 0; i < input; i++) result += word_Checker ();

    printf ("%d", result);
}