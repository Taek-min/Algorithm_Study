n = int(input())
one = []
two = []
three = []
for i in range(n):
    a, b, c = map(int, input().split())
    one.append(a)
    two.append(b)
    three.append(c)
for j in range(n):
    score = 0
    if one.count(one[j]) == 1:
        score += one[j]
    if two.count(two[j]) == 1:
        score += two[j]
    if three.count(three[j]) == 1:
        score += three[j]
    print(score)