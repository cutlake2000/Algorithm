#include <stdio.h>

int main(){
    int result, max = 0;
    int dice[3] = {0, 0, 0};

    scanf("%d %d %d", &dice[0], &dice[1], &dice[2]);

    // 모든 주사위 값이 같을 때
    if ((dice[0] + dice[1] + dice[2]) == (dice[0] * 3)){
        result = dice[0] * 1000 + 10000;
    }
    // 모든 주사위 값이 다를 때
    else if ((dice[0] != dice[1]) && (dice[1] != dice[2]) && (dice[2] != dice[0])){
        max = dice[0];

        for (int i = 1 ; i <= 2 ; i++){
            if (dice[i] >= max){
                max = dice[i];
            }
        }

        result = max * 100;
    }
    // 두 주사위 값이 같고, 남은 주사위 값과 다를 때
    else{
        if (dice[0] == dice[1]) result = dice[0] * 100 + 1000;
        else if (dice[1] == dice[2]) result = dice[1] * 100 + 1000;
        else if (dice[0] == dice[2]) result = dice[0] * 100 + 1000;
    }

    printf("%d", result);
}