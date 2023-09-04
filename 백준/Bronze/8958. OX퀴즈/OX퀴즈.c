#include<stdio.h>

int main(){
    char result[80] = {0,};
    int input = 0, score = 0, sum = 0;
    scanf("%d", &input);
    
    for (int i = 0 ; i < input ; i++){
        scanf("%s", result);
        
        for(int j = 0 ; j < 80 ; j++){
            if(result[j] == 'O'){
                score++;
                sum += score;
            }
            else if(result[j] == 'X'){
                score = 0;
            }
            else {
                break;
            }
        }
        printf("%d\n", sum);
        sum = 0;
        score = 0;
    }
}
