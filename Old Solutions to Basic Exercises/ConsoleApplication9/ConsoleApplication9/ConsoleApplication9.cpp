// ConsoleApplication9.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int number;
	cin >> number;

	int number_of_stars = 1;
	if (number % 2 == 0)
	{
		number_of_stars++;
	}
	int number_of_dashes = (number - number_of_stars) / 2;
	cout << string(number_of_dashes, '-')
		<< string(number_of_stars, '*')
		<< string(number_of_dashes, '-') << endl;
	int number_of_inner_dashes = number_of_stars;
	for (int rows = 1; rows <= (number - 1) / 2; rows++)
	{
		int number_of_outer_dashes = (number - number_of_inner_dashes - 2) / 2;
		cout << string(number_of_outer_dashes, '-')
			<< "*"
			<< string(number_of_inner_dashes, '-')
			<< "*"
			<< string(number_of_outer_dashes, '-')
			<< endl;
		number_of_inner_dashes += 2;
	}
	number_of_inner_dashes -= 4;
	for (int rows = (number - 1) / 2 - 1; rows > 0; rows--)
	{
		int number_of_outer_dashes = (number - number_of_inner_dashes - 2) / 2;
		cout << string(number_of_outer_dashes, '-')
			<< "*"
			<< string(number_of_inner_dashes, '-')
			<< "*"
			<< string(number_of_outer_dashes, '-')
			<< endl;
		number_of_inner_dashes -= 2;
	}
	if (number > 2)
	{
		cout << string(number_of_dashes, '-')
			<< string(number_of_stars, '*')
			<< string(number_of_dashes, '-') << endl;
	}

}