#include <stdio.h>
#include <math.h>
#define ll long long

ll h_Width, h_Height, h_Length, result = 0;

ll counting_Carrot(ll len){
    ll carrot = 0;
    ll temp = len - 1;

    for(ll i = 1 ; i < len ; i++){
        while(pow(i, 2) + pow(temp, 2) > pow(len, 2)) temp--;
        carrot += temp;
    }

    return carrot;
}

ll remove_Carrot(){
    ll carrot = 0;
    ll temp = h_Length - h_Height - 1;

    for (ll i = h_Height + 1 ; i < h_Length - h_Width ; i++){
        while((pow(i - h_Height, 2) + pow(temp, 2) > pow(h_Length - h_Height, 2))
        || (pow(temp - h_Width, 2) + pow(i, 2) > pow(h_Length - h_Width, 2))) temp--;

        carrot += (temp - h_Width);
    }

    return carrot;
}

int main(){
    scanf("%lld %lld %lld", &h_Width, &h_Height, &h_Length);

    result += counting_Carrot(h_Length) * 3 + h_Length * 2;
    if (h_Length > h_Height) result += counting_Carrot(h_Length - h_Height) + h_Length - h_Height;
    if (h_Length > h_Width) result += counting_Carrot(h_Length - h_Width) + h_Length - h_Width;
    if ((h_Length - h_Height) > h_Width && (h_Length - h_Width) > h_Height) result -= remove_Carrot();

    printf("%lld", result);

    return 0;
}