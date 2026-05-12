#include<iostream>

int main(){

    for(int i=0;i<3;i++){

        char x='A'+i;
        std::cout<<"\n";

        for(int k=0;k<3;k++){
            char j=x+k;
            std::cout<<" "<<j;
        }
    }

    return 0;
}