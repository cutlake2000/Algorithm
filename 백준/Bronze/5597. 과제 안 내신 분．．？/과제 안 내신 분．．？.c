#include <stdio.h>

int main(){
    int check[30] = {0,};
    int temp;

    for (int i = 0 ; i < 28 ; i ++){
        temp = 0;
        scanf("%d", &temp);
        check[temp - 1] = 1;
    }

    for (int i = 0 ; i < 30 ; i++){
        if (check[i] == 0) printf("%d\n", i + 1);
    }
}