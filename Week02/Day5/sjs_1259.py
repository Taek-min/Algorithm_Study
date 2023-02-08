<<<<<<< Updated upstream
#팰린드롬수_221226

while(True):
    word = str(input())
    yorn = True
    word = list(word)
    for i in range(0,len(word)//2): 

        if word[i] == word[len(word)-1 - i] :
            continue
        else :
            yorn = False
    yorn  = True

    if yorn : print('no')
    else : print('yes')       

## 굳
=======
print(3)
>>>>>>> Stashed changes
