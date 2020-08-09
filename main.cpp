#include <iostream>
using namespace std;
int main() {
  for(int i = 1; i <= 100; i++){
    if(i % 7 == 0){
      cout << "boom" << endl;
    } else {
      cout << i << endl;
    }
  }
}