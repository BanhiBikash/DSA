#include<iostream>

int main(){

    int j=1;

    for(int i=1;i<=4;i++){

        std::cout<<"\n";
        for(int k=0;k<i;k++){
            std::cout<<j;
            j++;
        }

    }

    return 0;
}