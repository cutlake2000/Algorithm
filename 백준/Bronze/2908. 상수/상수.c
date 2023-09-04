#include <stdio.h>

int main(){
    int i, j, count = 0;
    int num [2][3] = {0,};
    
    for (i = 0 ; i < 2 ; i++){
        for (j = 0 ; j < 3; j++){
            scanf("%1d", &num[i][j]);
            // printf("num [%d][%d] : %d\n", i, j, num[i][j]);
        }
    }
    
    for (i = 2 ; i >= 0 ; i--){
        if (num [0][i] > num[1][i]){
            count = 0;
            break;
        }
        else if (num [0][i] < num[1][i]){
            count = 1;
            break;
        }
    }
    
    for (i = 2 ; i >= 0 ; i--) printf("%d", num[count][i]);
}
