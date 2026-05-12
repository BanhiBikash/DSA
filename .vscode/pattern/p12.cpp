#include<iostream>

int main()
{
    int r;
    std::cout<<"\n enter the number of rows required\n:-";
    std::cin>>r;

    for(int i=1;i<=r;i++){
        std::cout<<"\n";
        for(int k=1;k<(r+1-i);k++){
            std::cout<<" ";
        }

        for(int j=1;j<=i;j++){
            std::cout<<j;
        }

        for(int j=(i-1);j>=1;j--){
            std::cout<<j;
        }
    }
    return 0;
}
