#include <stdio.h>
#include <stdlib.h>

int main(){
    int i, j;
    int team_Num, temp_Num;
    int* student_Num;
    
    scanf("%d", &team_Num);
    student_Num = malloc(sizeof(int) * team_Num * 2);
    
    for (i = 0 ; i < team_Num * 2 ; i++) scanf("%d", &student_Num[i]);
    
    for (i = 0 ; i < team_Num * 2 ; i++){
        for (j = 0 ; j < team_Num * 2 ; j++){
            temp_Num = 0;
            if ((student_Num[j] > student_Num[j + 1]) && (j + 1 < team_Num * 2)){
                temp_Num = student_Num[j];
                student_Num[j] = student_Num[j + 1];
                student_Num[j + 1] = temp_Num;
            }
        }
    }
    
    temp_Num = student_Num[0] + student_Num[team_Num * 2 - 1];

    for (i = 0 ; i < team_Num ; i++){
        if (temp_Num > student_Num[i] + student_Num[team_Num * 2 - 1 - i])
            temp_Num = student_Num[i] + student_Num[team_Num * 2 - 1 - i];
    }
    
    printf("%d\n", temp_Num);
}
