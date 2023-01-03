N, M = map(int, input().split())

S1 = set()
for i in range(N):
    S1.add(input())

S2 = set()
for i in range(M):
    S2.add(input())

result = sorted(list(S1 & S2))

print(len(result))

for i in result:
    print(i)