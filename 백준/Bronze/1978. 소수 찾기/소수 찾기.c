// 백준 알고리즘 1978번
// "소수 찾기"
// https://www.acmicpc.net/problem/1978

#include <stdio.h>
#include <stdlib.h>

int main(){
    int input, count;
    int* input_Num = NULL;
    input = count = 0;
    input_Num = (int*) malloc(sizeof(int) * input);
    scanf("%d", &input);

    for(int i = 0 ; i < input ; i++) scanf("%d", &input_Num[i]);

    for (int i = 0 ; i < input ; i++){
        if (input_Num[i] == 2) count++;
        else if (input_Num[i] > 2){
            for(int j = 2 ; j < input_Num[i] ; j++){
                if ((input_Num[i] % j) == 0){
                    break;
                }
                else if (j == input_Num[i] - 1){
                    count++;
                    break;
                }
            }
        }
    }
    printf("%d", count);
}