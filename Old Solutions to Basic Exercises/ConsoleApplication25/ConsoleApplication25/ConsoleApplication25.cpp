// ConsoleApplication25.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "string"
using namespace std;

int main()
{//declaration
	int number;
	cin >> number;
	int number_of_spaces = number - 1;
	int number_of_equals = number * 3 + 5;
	int number_of_waves = (3 * number + 6) - number - 2;
	int java = number / 2;
	int four_waves = 4;
	int number_of_a = 2 * number + 4;
	int last_equals = number - 1;
	int last_equals_end = number_of_equals - last_equals;

	//smoke from the cup
	for (int rows = 1; rows <= number; rows++)
	{
		cout << string(number_of_spaces, ' ');
		for (int columns = 1; columns <= 3; columns++)
		{

			cout << " ~";
		}
		cout << endl;
	}
	
	cout << string(number_of_equals, '=') << endl;
	for (int rows = 1; rows <= number - 2; rows++)
	{
		cout << "|";
		cout << string(number_of_waves / 2 - 2, '~');
		if (java == rows)
		{
			cout << "JAVA";
		}
		else
		{
			cout << string(four_waves, '~');
		}
		cout << string(number_of_waves / 2 - 2, '~');
		cout << "|";
		cout << string(number_of_spaces, ' ');
		cout << "|";

		cout << endl;

	}

	cout << string(number_of_equals, '=') << endl;
	//lower body of the cup
	for (int rows = 1; rows <= number; rows++)
	{
		int number_of_space2 = rows - 1;
		cout << string(number_of_space2, ' ');
		cout << "\\";

		cout << string(number_of_a, '@');
		cout << "/";
		number_of_a -= 2;
		cout << endl;
	}
	cout << string(last_equals_end, '=') << endl;

}