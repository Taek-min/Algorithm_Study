#첫째 줄에는 오영식이 이미 가지고 있는 랜선의 개수 K, 

#그리고 필요한 랜선의 개수 N이 입력된다. 
k, n = map(int,input().split())
LAN = [int(input()) for i in range(k)]

start, end = 1, max(LAN)

#그리고 항상 K ≦ N 이다. 
#그 후 K줄에 걸쳐 이미 가지고 있는
#각 랜선의 길이가 센티미터 단위의 정수로 입력된다. 
#랜선의 길이는 231-1보다 작거나 같은 자연수이다.
while start <= end :
    mid = (start + end) //2
    lines = 0

    for i in LAN: #mid 길이만큼 분할
        lines += i //mid

    if lines >= n:
        start = mid+1
      # max = mid
    else:
        end = mid -1

print(end)                