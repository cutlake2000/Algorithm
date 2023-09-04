#include <stdio.h>
#include <stdlib.h>

int main(){
    int input, check, count;
    input = check = count = 0;

    scanf("%d", &input);

    int *inputNum = malloc(sizeof(int) * input);

    for (int i = 0 ; i < input ; i++){
        scanf("%d", &inputNum[i]);   
    }

    scanf("%d", &check);

    for (int i = 0 ; i < input ; i++){
        if (check == inputNum[i]) count++;
    }

    printf("%d", count);

    free(inputNum);
}