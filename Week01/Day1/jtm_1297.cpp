#include <iostream>
#include <cmath>
using namespace std;
int main(){
    int diag, heightR, widthR, height, width;
    cin >> diag >> heightR >> widthR;
    cout<< (int)(diag/sqrt(pow(heightR, 2) + pow(widthR, 2))*heightR) << " " <<  (int)(diag/sqrt(pow(heightR, 2) + pow(widthR, 2))* widthR);
}//½ÉÇÃ ±»