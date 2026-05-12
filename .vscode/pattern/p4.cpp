#include<iostream>

int main(){

    for(int i=1;i<=3;i++){
        std::cout<<"\n";
        
        char x='A'+i-1;
        for(int k=0;k<3;k++){
            std::cout<<" "<<x;
        }
    }

}