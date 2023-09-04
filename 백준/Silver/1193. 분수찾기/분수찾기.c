#include <stdio.h>

int main(){
    long input = 0, num = 1, check = 0, location = 0, a = 1, reverse = 1;
    
    scanf("%ld", &input);
    
    while (num <= input){
        check += 1;
        num += check;
        
        if (reverse == 1) reverse = 0;
        else reverse = 1;
    }
    
    location = input - (num - check);
    
    if (location != 0){
        a += location;
        check -= location;
    }
    
    if (reverse != 0) printf("%ld/%ld\n", a, check);
    else printf("%ld/%ld\n", check, a);
}
