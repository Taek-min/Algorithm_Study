#include <iostream>
#include <algorithm>

using namespace std;
int main()
{
    int testerNum, awardNum, score;
    int *p;
    cin >> testerNum;
    cin >> awardNum;
    p = new int[testerNum];

    for(int i = 0; i < testerNum; i++){
        cin >> score;
        p[i] = score;
    }

    sort(p, p+testerNum, greater<int>());
    cout << p[awardNum-1];
    delete[] p;
    
    return 0;
}

//깔금하게 잘 풀엇네, 자바는 간만에 보니 어렵네요