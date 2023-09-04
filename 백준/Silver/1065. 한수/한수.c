#include <stdio.h>

int main(){
    int input = 0, result = 0, firstNum = 0, nowNum = 0;
    int checkNum[1001] = {0,};
    scanf("%d", &input);
    
    for (int i = 1 ; i <= input ; i++){
        if (i < 100){
            checkNum[i]++;
        }
        else if (i >= 100){
            for (firstNum = 1 ; firstNum < 10 ; firstNum++){
                for (int n = -4 ; n < 5 ; n++){
                    if (0 <= (firstNum + 2 * n) && (firstNum + 2 * n) < 10){
                        nowNum = (firstNum * 100) + ((firstNum + n) * 10) + (firstNum + 2 * n);
                    }
                    
                    if (nowNum <= input){
                        checkNum[nowNum]++;
                    }
                }
            }
        }
    }
    
    for(int j = 1 ; j < 1001 ; j++){
        if(checkNum[j] > 0){
            result++;
        }
    }
    
    printf("%d\n", result);
}
