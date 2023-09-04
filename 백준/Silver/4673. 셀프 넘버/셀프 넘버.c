#include <stdio.h>

int cal(int* nowNum){
    int num = *nowNum;
    int result = 0;
    
    result += num + num % 10;
    
    while (num > 0){
        num = num / 10;
        result += num % 10;
        
        if (num < 10){
            break;
        }
    }
    
    if (result > 10000){
        result = 0;
    }
    
    return result;
}

int main(){
    int i;
    int selfNum[10001] = {0,};
    
    for (i = 1 ; i < 10001 ; i++){
        selfNum[cal(&i)]++;
    }
    
    for (i = 1 ; i < 10001 ; i++){
        if (selfNum[i] == 0){
            printf("%d\n", i);
        }
    }
}
