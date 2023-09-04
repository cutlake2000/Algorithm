#include <stdio.h>

int main(){
    int now_Hour, now_Minute, need_Time = 0;
    scanf("%d %d", &now_Hour, &now_Minute);
    scanf("%d", &need_Time);

    now_Minute += need_Time;

    if (now_Minute / 60 != 0){
        now_Hour += (now_Minute / 60);
        now_Minute %= 60;

        if (now_Hour >= 24) now_Hour %= 24;
    }

    printf("%d %d", now_Hour, now_Minute);
}