if __name__ == '__main__':
    n = int(input())
    s = input()
    sList = []
    for i in range(0, n * 6, 6):
        sList.append(s[i: i + 6])
    replace = ['000000', '001111', '010011', '011100', '100110', '101001', '110101', '111010']

    correct = ''
    incorrect = 0
    for i in    sList:
        incorrect = 0
        for j in replace:
            cnt = 0  
            for k in range(6):
                if i[k] == j[k]:
                    cnt += 1
            if cnt >= 5:  
                correct += chr(replace.index(j) + 65)
                break
            else:  
                incorrect += 1
        if incorrect == len(replace):
            print(sList.index(i) + 1)
            quit()
    print(correct)
    #비슷하게 풀었네윤