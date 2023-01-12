from collections import deque
N,k =map(int,input().split())
q = deque([ i for i in range(1,N+1)])
answer = []
a = k
while len(q) >= 1:
    if a!=1:
        q.rotate(-1)
        a -=1
    else:
        answer.append(q.popleft())
        a=k
print("<",end='')
for i in range(N):
    if i != N-1:
        print('{},'.format(answer[i]),end='')
    else:
        print(answer[i],end='')
print('>')    