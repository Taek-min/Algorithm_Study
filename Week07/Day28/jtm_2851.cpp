#include <iostream>

using namespace std;

int findHundred(int num[]){
    int sum = 0;
    int underHun, overHun;
    for(int i = 0; i < 10; i++){
        sum += num[i];
        if(sum <= 100){
            underHun = sum;
        }
        else if(100 <= sum){
            overHun = sum;
            break;
        }
    }
    if(100-underHun < overHun-100){
        return underHun;
    }
    else if(100-underHun >= overHun-100){
        return overHun;
    }
    
}


int main()
{
    int num[10];
    int sum = 0;
    for(int i = 0; i < 10; i++){
        cin >> num[i];
    }
    
    cout << findHundred(num);
}

