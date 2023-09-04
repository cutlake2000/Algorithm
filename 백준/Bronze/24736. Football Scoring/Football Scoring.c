#include <stdio.h>

int main(){
    int visiting_Team[5] = {0,};
    int home_Team[5] = {0,};

    for (int i = 0 ; i < 5 ; i++) scanf("%d", &visiting_Team[i]);
    for (int i = 0 ; i < 5 ; i++) scanf("%d", &home_Team[i]);

    printf("%d ", 6 * visiting_Team[0] + 3 * visiting_Team[1] + 2 * visiting_Team[2] + 1 * visiting_Team[3] + 2 * visiting_Team[4]);
    printf("%d", 6 * home_Team[0] + 3 * home_Team[1] + 2 * home_Team[2] + 1 * home_Team[3] + 2 * home_Team[4]);
}