// ConsoleApplication27.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{

		char capitalLetter;
		char letter;
		char letter2;
		char letter3;
		int numbers;
		int sum = -1;
		cin >> capitalLetter >> letter >> letter2 >> letter3 >> numbers;

		for (char a = 'A'; a <= capitalLetter; a++)
		{
			for (char b = 'a'; b <= letter; b++)
			{
				for (char c = 'a'; c <= letter2; c++)
				{
					for (char d = 'a'; d <= letter3; d++)
					{
						for (int number = 0; number <= numbers; number++)
						{
							
							cout << a << b << c << d << number << endl;
							sum++;
							
							
						}
					}
				}
			}
		}
		cout << sum << endl;





		return 0;
	}



