N,M = map(int, input().split())
board = []

for i in range(N):
    board.append(input())

newBoard = []

for row in range(N - 7): 
        for column in range(M - 7):
            startW = 0
            startB = 0
            for i in range(row,row+8):
                for j in range(column,column+8):  
                    if (i+j)%2 == 0:
                        if board[i][j] != 'W':
                            startW+=1  
                        else: 
                            startB+=1
                    else:
                        if board[i][j] != 'B':
                            startW+=1 
                        else: 
                            startB+=1
            newBoard.append(startW)
            newBoard.append(startB)

print (min(newBoard))

