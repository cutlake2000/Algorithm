// 백준 알고리즘 2581번
// "소수"
// https://www.acmicpc.net/problem/2581

#include <stdio.h>

int main(){
    int min, sum, prime_Num;
    min = sum = prime_Num = 0;
    int input[2] = {0,};
    for (int i = 0 ; i < 2 ; i++) scanf("%d", &input[i]);

    for (int i = input[0] ; i <= input[1] ; i++){
        if (i == 2) prime_Num = 1;
        else{
            for (int j = 2 ; j < i ; j++){
                if(i % j == 0) break;
                else if (j == i - 1) prime_Num = 1;
            }
        }

        if (prime_Num == 1){
            if(min == 0) min = i;
            sum += i;
            prime_Num = 0;
        }
    }

    if (min == 0) printf("-1");
    else printf("%d\n%d", sum, min);
}