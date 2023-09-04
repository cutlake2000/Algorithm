#include <stdio.h>
#include <string.h>

int main(){
    int i, len;
    int count = 1;
    char word[1000000] = {0,};
    
    scanf("%[^\n]", word);
    len = (int)strlen(word);
    
    if(len == 0) count--;
    else if (len == 1) count = word[0] == ' ' ? 0 : 1;
    else{
        for (i = 1 ; i < len-1 ; i++){
            if(word[i] == ' ') count++;
        }
    }
    printf("%d\n", count);
}
