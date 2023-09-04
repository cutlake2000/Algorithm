#include <stdio.h>

int main(void){
    int testCase = 0;
    int floor_Num, room_Num, guest_Num;
    int first_Num, second_Num;
    scanf("%d", &testCase);
    
    for (int i = 0 ; i < testCase ; i++){
        floor_Num = 0; // 층 수
        room_Num = 0; // 각 층에 존재하는 방의 개수
        guest_Num = 0; // 손님 수
        first_Num = 0; // 룸넘버 앞 두 자리
        second_Num = 0; // 룸넘버 뒤 두 자리
        
        scanf ("%d %d %d", &floor_Num, &room_Num, &guest_Num);
        
        if ((guest_Num % floor_Num) != 0){
            first_Num = guest_Num % floor_Num;
            second_Num = guest_Num / floor_Num + 1;
        }
        else{
            first_Num = floor_Num;
            second_Num = guest_Num / floor_Num;
        }
        printf("%d%02d\n", first_Num, second_Num);
    }
}
