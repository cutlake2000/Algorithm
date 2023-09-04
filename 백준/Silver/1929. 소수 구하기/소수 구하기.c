#include <stdio.h>

int main(){
    int inputA, inputB;
    int Aretostes[1000001];

    scanf("%d %d", &inputA, &inputB);

    for (int i = 2 ; i < 1000001 ; i++) Aretostes[i] = 1;

    for (int i = 2; i <= inputB; i++){
        for (int j = i * 2 ; j <= inputB; j += i) Aretostes[j] = 0;
    }

    for (int i = inputA ; i <= inputB ; i++){
        if (Aretostes[i] == 1) printf("%d\n", i);
    }

    return 0;
}
