// ConsoleApplication3.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "string"
using namespace std;

int main()

{int number;
cin >> number;
	for (int  rows = 0; rows <= number; rows++)
	{
		int number_of_spaces = number - rows;
		int number_of_stars = rows;
		string spaces = string(number_of_spaces, ' ');
		string stars = string(number_of_stars, '*');
		cout << spaces << stars << " | " << stars << endl;
	}
	
}

