#include<iostream>

int main(){

    for(int i=0;i<3;i++){
        std::cout<<"\n";
        char x='A'+i;

        for(int k=0;k<=i;k++){
            std::cout<<" "<<x;
        }
    }
}