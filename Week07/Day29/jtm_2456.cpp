#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
struct Student {
    int point[5];
}students[4];
 
int player[4] = { 0, 1, 1, 1 };
int checkPlayer(int pivot) {
    int i, value = 0;

    for (i = 1; i <= 3; ++i) {
        if (player[i]) {
            value = value < students[i].point[pivot] ? students[i].point[pivot] : value;
        }
    }
     

    for (i = 1; i <= 3; ++i) {
        if (player[i] && value > students[i].point[pivot]) {
            player[i] = 0;
        }
    }
     
    int cnt = 0;

    for (i = 1; i <= 3; ++i) {
        if (player[i]) cnt++;
    }

    if (cnt == 1) {
        for (i = 1; i <= 3; ++i) {
            if (player[i]) {
                printf("%d %d", i, students[i].point[4]);
                return 1;
            }
        }
    }
    return 0;
}
 
int main(void) {

     
    int N, vote[4];
    scanf("%d", &N);
    while(N--){
        for (int i = 1; i <= 3; ++i) {
            scanf("%d", &vote[i]);
            students[i].point[4] += vote[i];
            students[i].point[vote[i]]++;
        }
    }
     

    for (int i = 4; i >= 2; --i) {
        if (checkPlayer(i))
            return 0;
    }

    int value = 0;
    for (int i = 1; i <= 3; ++i) {
        value = value < students[i].point[4] ? students[i].point[4] : value;
    }
    printf("0 %d", value);
}