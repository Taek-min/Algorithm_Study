n=int(input())
s=[]
ans=[]
cnt=1
temp=True
for i in range(n):
    num = int(input())
    while cnt <= num:
        s.append(cnt)
        ans.append('+')
        cnt += 1
    if s[-1] == num:
        s.pop()
        ans.append('-')
    else:
        temp = False
if temp == False:
    print('NO')
else:
    for i in ans:
        print(i)