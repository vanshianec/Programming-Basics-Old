// ConsoleApplication19.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
using namespace std;

int main()
{
	int number;
	cin >> number;
	
	for (int rows = 0; rows < number; rows++)
	{
		for (int columns = 0; columns < number; columns++)
		{
			int counter = rows + columns + 1;
			if (counter > number)
			{
				counter = number * 2 - counter;
			}
			cout << counter << " ";

		 }
		cout << endl;


	}

}

