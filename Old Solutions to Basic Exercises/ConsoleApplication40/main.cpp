#include <iostream>

using namespace std;

int main()
{
  int number;
  cin>>number;


     for (int a=1;a<=9;a++)
     {

         for (int b=1;b<=9;b++)
         {

             for (int c=1;c<=9;c++)
             {

                 for(int d=1;d<=9;d++)
                 {
                     if ((a+b==c+d)&&(number%(a+b)==0))
                     {

                         cout<<a<<b<<c<<d;
                         cout<<" ";
                     }


                 }
             }
         }
     }
}
