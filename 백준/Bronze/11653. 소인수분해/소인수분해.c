#include <stdio.h>

int main(){
    int input = 0;
    int temp = 2;
    scanf("%d", &input);

    if (input != 1){
        while(input != 1){
            if ((input % temp) == 0){
                input /= temp;
                printf("%d\n", temp);
            }
            else temp++;
        }
    }
}