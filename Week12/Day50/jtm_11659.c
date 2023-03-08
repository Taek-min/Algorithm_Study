#include <stdio.h>
long long arr[100001];
long long prefix_sum[100001];

int main()
{
    int N, M;
    int num1, num2;
    long long sum = 0;
    scanf("%d %d", &N, &M);
    
    for(int i = 0; i < N; i++){
        scanf("%lld", &arr[i]);
        prefix_sum[i+1] = prefix_sum[i] + arr[i];
    }
    
    for(int i = 0; i < M; i++){
        scanf("%d %d", &num1, &num2);
        sum = prefix_sum[num2] - prefix_sum[num1-1]; 
        printf("%lld\n", sum);
    }  
}