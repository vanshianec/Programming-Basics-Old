

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int size;
	cin >> size;

	int exceptional_stars = 1;
	if (size % 2 == 0)
	{
		exceptional_stars++;
	}

	int exceptional_dashes = (size - exceptional_stars) / 2;

	//First Line
	cout << string(exceptional_dashes, '-')
		<< string(exceptional_stars, '*')
		<< string(exceptional_dashes, '-')
		<< endl;

	//First half of body
	int number_of_rows = (size - 1) / 2;
	int number_of_inner_dashes = exceptional_stars;
	for (int row = 1; row <= number_of_rows; row++)
	{
		int number_of_outer_dashes = (size - number_of_inner_dashes - 2) / 2;

		cout << string(number_of_outer_dashes, '-')
			<< "*"
			<< string(number_of_inner_dashes, '-')
			<< "*"
			<< string(number_of_outer_dashes, '-')
			<< endl;

		number_of_inner_dashes += 2;
	}

	number_of_inner_dashes -= 4;
	//Second half of body
	for (int row = number_of_rows - 1; row > 0; row--)
	{
		int number_of_outer_dashes = (size - number_of_inner_dashes - 2) / 2;

		cout << string(number_of_outer_dashes, '-')
			<< "*"
			<< string(number_of_inner_dashes, '-')
			<< "*"
			<< string(number_of_outer_dashes, '-')
			<< endl;

		number_of_inner_dashes -= 2;
	}


	//Last Line
	if (size > 2)
	{
		cout << string(exceptional_dashes, '-')
			<< string(exceptional_stars, '*')
			<< string(exceptional_dashes, '-')
			<< endl;
	}

	return 0;
}


