#include <stdio.h>
#include <stdlib.h>

int main(){
    int input = 0;
    double studentNum, sum, average, count;
    int* score;
    scanf("%d", &input);
    
    for (int i = 0 ; i < input ; i ++){
        studentNum = sum = average = count = 0;
        scanf("%lf", &studentNum);
        score = malloc (studentNum * sizeof(int));
        
        for (int j = 0 ; j < studentNum ; j++){
            scanf("%d", &score[j]);
            sum += score[j];
        }
        
        average = sum / studentNum;
        
        for (int j = 0 ; j < studentNum ; j++){
            if (score[j] > average){
                count++;
            }
        }
        
        printf("%.3f%%\n", 100 * count / studentNum);
        free(score);
    }
}
