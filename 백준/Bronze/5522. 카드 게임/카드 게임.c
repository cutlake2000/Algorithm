int main(){
    int temp, result;
    temp = result = 0;

    for (int i = 0 ; i < 5 ; i++){
        temp = 0;
        scanf("%d", &temp);
        result += temp;
    }

    printf("%d", result);
}