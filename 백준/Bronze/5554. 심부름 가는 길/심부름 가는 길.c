#include <stdio.h>

int main(){
    int fir_Time, sec_Time, thir_Time, four_Time, output;
    fir_Time = sec_Time = thir_Time = four_Time = output = 0;
    scanf("%d\n%d\n%d\n%d", &fir_Time, &sec_Time, &thir_Time, &four_Time);

    output = fir_Time + sec_Time + thir_Time + four_Time;
    
    printf("%d\n%d", output / 60, output % 60);
}