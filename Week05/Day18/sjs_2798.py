n,m = map(int, input().split())
lst = list(map(int, input().split()))
sum = 0
for i in range(n):
    for j in range(i+1, n):
        for k in range(j+1,n):
            if lst[i] + lst[j] + lst[k] > m:
                continue
            else:
                sum = max(sum, lst[i]+lst[j]+lst[k])
print(sum)