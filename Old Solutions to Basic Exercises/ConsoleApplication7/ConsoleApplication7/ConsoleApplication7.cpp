// ConsoleApplication7.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "string"

using namespace std;
int main()
{
	int number;
	cin >> number;
	int number_of_rows = (number + 1) / 2;
	int number_of_stars = 1;
	if (number % 2 == 0)
	{
		number_of_stars += 1;
	}
	
	int number_of_dashes = (number - number_of_stars) / 2;
	for (int rows = 1; rows <= number_of_rows; rows++)
	{
		cout << string(number_of_dashes, '-') << string(number_of_stars, '*') << string(number_of_dashes, '-') << endl;
		number_of_stars += 2;
		number_of_dashes -= 1;

	}
	
	
	for (int rows = 1; rows <= number/2 ; rows++)
	{
		int number_of_stars = number - 2;
		int number_of_pipes = 1;

		cout << string(number_of_pipes, '|') << string(number_of_stars, '*') << string(number_of_pipes, '|') << endl;
	}

 
}

