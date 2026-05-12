#include<iostream>

int main()
{
    for(int i=1;i<5;i++){
        std::cout<<"\n";
        for(int k=0;k<i;k++){
            std::cout<<"  ";
        }

        for(int k=0;k<(5-i);k++){
            std::cout<<" "<<i;
        }
    }
    return 0;
}

// Output
//    1 1 1 1
//      2 2 2
//        3 3
//          4