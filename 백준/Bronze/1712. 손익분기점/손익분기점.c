#include <stdio.h>

long break_Even_point(long FC, long VC, long P){
    long X = 0;
    
    if (VC >= P) X = -1;
    else{
        X = FC / (P - VC) + 1;
    }
    
    return X;
}

int main(){
    long A = 0, B = 0, C = 0;
    
    scanf ("%ld", &A);
    scanf("%ld", &B);
    scanf("%ld", &C);
    
    printf("%ld", break_Even_point(A, B, C));
}
