// ConsoleApplication22.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "string"
#include "iomanip"
#include "cmath"
using namespace std;

int main()
{
	int kontrolna_stoinost;
	cin >> kontrolna_stoinost;
	int sum = 0;
	string password;

	for (int first_digit = 1; first_digit <= 9; first_digit++)
	{
		for (int second_digit = 1; second_digit <= 9; second_digit++)
		{
			for (int third_digit = 1; third_digit <= 9; third_digit++)
			{
				for (int forth_digit = 1; forth_digit <= 9; forth_digit++)
				{
					int value = first_digit*second_digit + third_digit*forth_digit;
					if (kontrolna_stoinost == value && first_digit<second_digit && third_digit>forth_digit)
						
				
					{
						
						cout << first_digit << second_digit << third_digit << forth_digit << " ";
						sum++;
						if (sum == 4)
						{
							password = to_string(first_digit);
							password = password + to_string(second_digit);
							password = password + to_string(third_digit);
							password = password + to_string(forth_digit);
						}

					}
				}

			}

		}

	}
	cout << endl;
	if (sum < 4)
	{
		cout << "No!" << endl;
	}
	else {cout << "Password: " << password << endl;

	}
	
}