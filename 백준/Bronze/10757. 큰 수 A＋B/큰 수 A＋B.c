#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main(){
    int* result;
    int A_Len, B_Len, result_Len, i, j, A_Temp, B_Temp, temp;
    char A_Num[10001] = {0,};
    char B_Num[10001] = {0,};
    
    A_Temp = B_Temp = temp = 0;
    result_Len = 1;
    
    scanf("%s %s", A_Num, B_Num);

    A_Len = strlen(A_Num);
    B_Len = strlen(B_Num);

    if (A_Len > B_Len){
        temp = A_Len;
        result_Len += A_Len;
        B_Temp = A_Len - B_Len;
    }
    else if (B_Len > A_Len){
        temp = B_Len;
        result_Len += B_Len;
        A_Temp = B_Len - A_Len; 
    }
    else{
        result_Len += A_Len;
        temp = A_Len;
    }

    result = (int*) malloc(sizeof(int) * result_Len);
    if (result == NULL) exit(1);
    memset(result, 0, sizeof(int) * result_Len);

    for (i = temp - 1 ; i >= 0 ; i--){
        if ((i - A_Temp) >= 0 && (i - B_Temp) >= 0) result[i + 1] += ((A_Num[i - A_Temp] + B_Num[i - B_Temp]) - ('0' * 2));
        else if (A_Temp != 0) result[i + 1] += (B_Num[i] - '0');
        else if (B_Temp != 0) result[i + 1] += (A_Num[i] - '0');

        if (result[i + 1] >= 10){
            result[i + 1] %= 10;
            result[i] += 1;
        }
    }

    for (i = 0 ; i < result_Len ; i++){
        if (result[i] != 0){
            j = i;
            break;
        }
    }

    for (i = j ; i < result_Len ; i++) printf("%d", result[i]);

    free(result);
}