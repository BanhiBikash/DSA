#include<iostream>

int main(){

    int j=0;
    for(int i=1;i<=3;i++){

        std::cout<<"\n";
        for(int k=0;k<3;k++){
            char x=('A'+j);
            std::cout<<" "<<x;
            j++;
        }
    }

    return 0;
}