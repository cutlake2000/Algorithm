#include <stdio.h>

int main(){
    int count;
    float input_Len, stick, stick_Len;
    
    stick_Len = 64.0;
    count = 0;
    input_Len = stick = 0.0;

    scanf("%f", &input_Len);

    if (stick != input_Len){
        while(stick != input_Len){
            if (stick < input_Len){
                stick += stick_Len;
                stick_Len /= 2;
                count++;
            }
            else if (stick > input_Len){
                stick -= (stick_Len * 2);
                count--;
            }
        }
    }

    printf("%d", count);
}