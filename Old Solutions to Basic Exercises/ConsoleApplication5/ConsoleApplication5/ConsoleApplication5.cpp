// ConsoleApplication5.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "string"
using namespace std;
int main()
{
	int number, number_of_stars, number_of_spaces, number_of_slashes, number_of_pipes,mid_value;
	cin >> number;
	//declaration
	mid_value = (number - 1) / 2;
	number_of_stars = number * 2;
	number_of_spaces = number;
	number_of_slashes = 2 * number - 2;
	number_of_pipes = number;
	string stars = string(number_of_stars, '*');
	string spaces = string(number_of_spaces, ' ');
	string slashes = string(number_of_slashes, '/');
	string pipes = string(number_of_pipes, '|');
	//first line
	cout << stars << spaces << stars << endl;
	//left glass
	for (int rows = 1; rows <= number - 2; rows++)
	{
		
		
		cout << "*" << slashes << "*";
		if (rows == mid_value)
		{
			cout << pipes;

		}
		else
		{
			cout << spaces;
		}
		

			cout << "*" << slashes << "*";
		cout << endl;

	}

	









	//last line
	cout << stars << spaces << stars << endl;

	

}