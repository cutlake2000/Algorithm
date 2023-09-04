#include <stdio.h>
#include <string.h>
#include <ctype.h>

int main(){
    int i, len, maxNum = 0, printNum = 0, count = 0;
    char word[1000001] = {0,};
    int check[26] = {0,};
    scanf ("%s", word);

    for (i = 0, len = (int)strlen(word); i < len; i++){
        word[i] = toupper(word[i]);
        check[word[i]-65]++;
    }
    
    for (i = 0 ; i < 26 ; i++){
        if (check[i] > maxNum){
            count = 0;
            maxNum = check[i];
            printNum = i;
        }
        else if (check[i] == maxNum){
            count++;
        }
    }
    
    if (count > 0) printf("?\n");
    else printf("%c\n", printNum+65);
}
