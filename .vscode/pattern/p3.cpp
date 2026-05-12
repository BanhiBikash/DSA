#include<iostream>

int main(){

    for(int i=1;i<=4;i++){
    std::cout<<"\n";

    for(int k=1;k<=i;k++){
        std::cout<<" "<<(i-k+1);
    }
    }
    return 0;
}
