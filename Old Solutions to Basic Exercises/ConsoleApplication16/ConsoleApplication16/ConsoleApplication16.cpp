// ConsoleApplication16.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
using namespace std;

int main()
{
	int number;
	cin >> number;
int previous_number = number - 1;
if (number == 1)
{
	cout << 1 << endl;
}
	do {
		
		number = number * previous_number;
		previous_number--;
		
	} while (previous_number > 0);
	cout << number << endl;

}

