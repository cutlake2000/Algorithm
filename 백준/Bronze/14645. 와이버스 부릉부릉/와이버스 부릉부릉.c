#include <stdio.h>

int main(){
    int num, person_Num, in, out;
    num = person_Num = in = out = 0;

    scanf("%d %d", &num, &person_Num);

    for (int i = 0 ; i < num ; i++){
        in = out = 0;
        scanf("%d %d", &in, &out);
    }
    
    printf("비와이");
}