#include <stdio.h>
#include <math.h>

int activate_Machine(int, int);

int main(){
    int i, x_Val, y_Val;
    int testCase = 0;

    scanf("%d", &testCase);
    
    for (i = 0 ; i < testCase ; i++){
        x_Val = y_Val = 0;
        scanf("%d %d", &x_Val, &y_Val);
        printf("%d\n", activate_Machine(x_Val, y_Val));
    }
}

int activate_Machine(x_Val, y_Val){
    int x2y_Distance, jump_Count, sqrt_Value, pow_Value;
    
    jump_Count = sqrt_Value = pow_Value = 0;
    x2y_Distance = y_Val - x_Val;

    if (x2y_Distance <= 3){
        switch (x2y_Distance)
        {
        case 1:
            jump_Count = 1;
            break;
        case 2:
            jump_Count = 2;
            break;
        case 3:
            jump_Count = 3;
            break;
        }
    }
    else{
        sqrt_Value = floor(sqrt(x2y_Distance));
        pow_Value = pow(sqrt_Value, 2.0);

        if (pow_Value >= x2y_Distance){
            jump_Count = sqrt_Value * 2 - 1;
        }
        else if (pow_Value < x2y_Distance && x2y_Distance <= (sqrt_Value + pow_Value)){
            jump_Count = sqrt_Value * 2;
        }
        else if (x2y_Distance > (sqrt_Value + pow_Value)){
            jump_Count = sqrt_Value * 2 + 1;
        }
    }

    return jump_Count;
}