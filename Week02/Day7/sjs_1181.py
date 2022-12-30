N  = int(input())

word = []
for i in range(N):
    word.append(input())

setWord = list(set(word))

sortedWord = []
for i in setWord:
    sortedWord.append((len(i),i))

result = sorted(sortedWord)

for lenWord, word in result:
    print(word)
## WOW
## 역시 파이썬은 날먹인가 :2