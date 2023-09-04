#include <stdio.h>

int main(){
    int delivery = 0, count = 0;
    scanf("%d", &delivery);
    
    while (1){
        if (delivery == 0){
            printf("%d", count);
            break;
        }
        else if (delivery < 3){
            printf("-1");
            break;
        }
        else{
            if (delivery % 5 == 0){
                count += delivery / 5;
                delivery = 0;
            }
            else{
                delivery -= 3;
                count++;
            }
        }
    }
}