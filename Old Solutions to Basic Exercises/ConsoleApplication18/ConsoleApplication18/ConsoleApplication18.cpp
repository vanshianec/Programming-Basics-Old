// ConsoleApplication18.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
using namespace std;

int main()
{
	int number;
	cin >> number; 
	int counter = 1;
	for (int rows = 1; rows <= number; rows++)
	{
		{
			for (int columns = 1; columns <= rows; columns++)

				
			counter++; }
     cout << counter << " ";
			if (counter > number)
				break;


		}
		if (counter > number)
			break;
		cout << endl;

	}
}

