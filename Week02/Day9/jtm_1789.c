#include <stdio.h>

int main()
{
    long long int N;
    scanf("%d", &N);
    long long int sum = 0;
    long long int cnt = 1;
    while(1){
        sum = sum + cnt;
        if(N < sum){
            printf("%d", cnt-1);
            break;
        }
        cnt++;
    }
    return 0;
}
