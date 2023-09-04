#include <stdio.h>
#include <string.h>

int main(){
    int i, j, k, check, nowNum = 0, result = 0;
    char word[8][4] = {
        {65, 66, 67, '0'},
        {68, 69, 70, '0'},
        {71, 72, 73, '0'},
        {74, 75, 76, '0'},
        {77, 78, 79, '0'},
        {80, 81, 82, 83},
        {84, 85, 86, '0'},
        {87, 88, 89, 90},};
    char input[16] = {0,};
    scanf("%s", input);
    int len = (int)strlen(input);
    
    for (i = 0 ; i < len ; i++){
        nowNum = input[i];
        check = 0;
        for (j = 0 ; j < 8 ; j++){
            if (check == 1) break;
            else{
                for (k = 0 ; k < 4 ; k++){
                    if(nowNum == word[j][k]){
                        result += (j + 3);
                        check = 1;
                        break;
                    }
                }
            }
        }
    }
    printf("%d\n", result);
}
