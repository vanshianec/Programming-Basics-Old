// ConsoleApplication17.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
using namespace std;

int main()
{
	int number;
	cin >> number;
	bool Prime = true;
	if (number >= 2)
	{
		for (int i = 2; i <= sqrt(number); i++)
		
			if (number%i == 0)
			{
				 Prime = false;
				break;
			}
			  if (Prime) cout << "Prime" << endl;
			
				
			

			else cout << "Not prime" << endl;
			
				
			

		}




	}
	else {cout << "Not prime" << endl;

	}
	




}
	
