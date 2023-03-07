import sys
input = sys.stdin.readline
N, M = map(int, input().split())
numbers = list(map(int, input().split()))
S = [0]
accum = 0

for i in numbers:
    accum += i
    S.append(accum)

for i in range(M):
    f, b = map(int, input().split())
    print(S[b] - S[f-1])