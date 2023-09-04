#include <stdio.h>
#include <math.h>

int main(){
    int a, b, c, temp_A, temp_B, temp_C;

    while(1){
        temp_A = temp_B = temp_C = 0;
        scanf("%d %d %d", &temp_A, &temp_B, &temp_C);
        if (temp_A == 0 && temp_B == 0 && temp_C == 0) break;
        
        a = temp_A;
        b = temp_B;
        c = temp_C;

        if (temp_B > a){
            a = temp_B;
            b = temp_A;
            c = temp_C;
        }
        if (temp_C > a){
            a = temp_C;
            b = temp_B;
            c = temp_A;
        }

        if (pow(a, 2) == (pow(b, 2) + pow(c, 2))) printf("right\n");
        else printf("wrong\n");
    }
}