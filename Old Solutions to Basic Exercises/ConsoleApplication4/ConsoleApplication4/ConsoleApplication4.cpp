// ConsoleApplication4.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "string"
using namespace std;

int main()
{//main and declarations;
	int number;
	cin >> number;
	
	int number_of_stars = number * 2;
	int number_of_spaces = number;
	int number_of_pipes = number;
	string stars = string(number_of_stars, '*');
	string spaces = string(number_of_spaces, ' ');
//First_line;
	cout << stars << spaces << stars << endl;

	for (int rows = 0; rows < number - 2; rows++)
	{
		cout << "*";
		for (int rows1 = 0; rows1 < 2 * number - 2; rows1++)
		{
			cout << "/";
		}
		cout << "*";
		
		
cout << endl;
	}

   

	
	
 //Last_line;
	cout << stars << spaces << stars << endl;
	 

    return 0;
}

