// ConsoleApplication23.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "string"
using namespace std;

int main()
{
	int number;
	cin >> number;

	for (int rows = number; rows >=1; rows--)
	{
		int number_of_spaces = number - rows;
		cout << string(number_of_spaces, ' ');
		for (int columns = 1; columns<=rows; columns++)
		{
         cout << "*";
		}
			
		cout << endl;
	}
	
}

