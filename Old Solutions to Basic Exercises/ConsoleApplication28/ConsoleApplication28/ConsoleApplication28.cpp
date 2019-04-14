// ConsoleApplication28.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "iomanip"
#include "string"
using namespace std;

int main()
{
	
	int M, N, L, specialNumber, controlNumber;
	cin >> M >> N >> L >> specialNumber >> controlNumber;

	bool statement = false;

	for (int a = M; a >=1; a--)

	{
		for (int b = N; b >=1; b--)
		{
			for (int c = L; c >= 1; c--)
			{
				if (specialNumber >= controlNumber)
				{
					statement = true;
					break;
				}

				else if ((a + b + c) % 3 == 0)
				{
					specialNumber += 5;
				}
				else if (c % 10 == 5)
				{
					specialNumber -= 2;
				}
				else if (c % 2 == 0)
				{
					specialNumber *= 2;
				}
			}
		}
	}
	if (statement)
	{
		cout << "Yes! Control number was reached! Current special number is " << specialNumber<<"." << endl;
	}
	else

	{
		cout << "No! " << specialNumber << " is the last reached special number." << endl;
			
	}
	



	

    
}

