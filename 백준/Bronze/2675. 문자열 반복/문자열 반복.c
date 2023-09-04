#include <stdio.h>

int main(){
    int i, j, k;
    int input = 0, num = 0;
    char word [21] = {0,};
    
    scanf ("%d", &input);
    
    for (i = 0 ; i < input ; i++){
        scanf ("%d", &num);
        scanf ("%s", word);
        
        for (j = 0 ; j < 21 ; j++){
            if (word[j] == '\0'){
                printf("\n");
                break;
            }
            else for (k = 0 ; k < num ; k++) printf("%c", word[j]);
        }
    }
}
