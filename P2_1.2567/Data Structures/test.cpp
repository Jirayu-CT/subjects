#include <iostream>
#include <cmath>
using namespace std;

int main(){

    int max, index;
    float number[] = {45, 55, 39, 28, 32};

    max = number[0];

    for(int i = 1; i < 5; i++){
        if(number[i] > max){
            max = number[i];
            index = i;
        }
    }

    cout << "Max number: " << max << endl;
    cout << "Index number: " << index;

    return 0;
}