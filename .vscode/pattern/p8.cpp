#include<iostream>

int main(){
    char x='D';    

    for(int i=0;i<4;i++){
        std::cout<<"\n";
        for(int k=i;k>=0;k--){
            char y=x-k;
            std::cout<<" "<<y;
        }
    }
}

// Output
//  D
//  C D
//  B C D
//  A B C D