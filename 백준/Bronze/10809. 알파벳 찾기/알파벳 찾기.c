#include <stdio.h>

int main(){
    int i, j;
    char word[101] = {0,};
    
    scanf("%s", word);
    
    for (i = 97 ; i <= 122 ; i++){
        for (j = 0 ; j < 101 ; j++){
            
            if (word[j] == i){
                printf("%d ", j);
                break;
            }
            else if (word[j] == '\0'){
                printf("-1 ");
                break;
            }
        }
    }
}
