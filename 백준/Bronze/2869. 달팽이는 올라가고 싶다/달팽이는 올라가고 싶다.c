#include <stdio.h>

int main(){
    int v = 0, a = 0, b = 0, count = 0;
    int climb;
    
    scanf("%d", &a);
    scanf("%d", &b);
    scanf("%d", &v);
    
    climb = a - b;
    v -= a;

    count = v / climb + 1;
    
    if (v % climb != 0) count++;
    
    printf("%d", count);
}
