#include <stdio.h>

int main(){
    int testCase, floor, room;
    scanf("%d", &testCase);
    
    for (int i = 0 ; i < testCase ; i++){
        int apart[15][15] = {0,};
        scanf("%d %d", &floor, &room);
        
        for (int j = 0 ; j <= floor ; j++) apart[j][0] = 1;
        for (int j = 1 ; j <= room ; j++) apart[0][j] = j;
        
        for (int j = 1 ; j <= floor ; j++){
            for (int k = 1 ; k <= room ; k++){
                for (int l = 1 ; l < k + 1 ; l++) apart[j][k] += apart[j - 1][l];
            }
        }
        
        printf("%d\n", apart[floor][room]);
    }
}