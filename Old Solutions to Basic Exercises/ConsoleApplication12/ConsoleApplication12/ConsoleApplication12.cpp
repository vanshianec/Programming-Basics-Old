// ConsoleApplication12.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


#include "iostream"
using namespace std;

int main()
{

	cout << "Enter a number in the range[1...100]:" << endl;
	int number;
	cin >> number;

	while (number<1 || number > 100)
	{
		cout << "Enter a number in the range[1...100]:" <<number<< endl;
		
		cout << "Invalid number!" << endl;
		cin >> number;
	}
	
	 cout << "The number is : " << number << endl;

	

	

}


