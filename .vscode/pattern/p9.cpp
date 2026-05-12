#include<iostream>
 
int main()
{
    for(int i=0;i<4;i++){
        std::cout<<"\n";
        for(int k=0;k<(3-i);k++){
            std::cout<<"  ";
        }
        for(int k=0;k<=i;k++){
            std::cout<<" *";
        }
    }

    return 0;
}

// Output
//        *
//      * *
//    * * *
//  * * * *