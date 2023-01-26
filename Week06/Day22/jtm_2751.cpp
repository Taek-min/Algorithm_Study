#include <iostream>
#include<algorithm>
using namespace std;

int main()
{
    int N, num;
    int* arrNum = new int[N];
    cin >> N;
    for(int i = 0; i < N; i++){
        cin >> num;
        arrNum[i] = num;
    }
    sort(arrNum, arrNum+N);
    for(int i = 0; i < N; i++){
        cout << arrNum[i] << "\n";
    }
    delete[] arrNum;
}//EZ
