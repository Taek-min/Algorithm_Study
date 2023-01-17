N,M = map(int,input().split())
A=list(map(int,input().split()))
B=list(map(int,input().split()))

abc=A+B
abc.sort()

print(" ".join(map(str,abc)))
# 부럽네요 ^오^ 