#include <stdio.h>

int main(){
    long long total;
    long tmp1;
    int count, tmp2;
    total = count = tmp1 = tmp2 = 0;

    scanf("%lld\n%d", &total, &count);

    for (int i = 0 ; i < count ; i++){
        tmp1 = tmp2 = 0;
        scanf("%ld %d", &tmp1, &tmp2);
        total -= (tmp1 * tmp2);
    }

    if (total == 0) printf("Yes");
    else printf("No");
}