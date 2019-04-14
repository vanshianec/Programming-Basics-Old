// ConsoleApplication29.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "cmath"
#include "iomanip"

using namespace std;

int main()
{
	int distance, razhod, sum;
	double gorivoZaLitur;
	cin >> distance >> razhod >> gorivoZaLitur >> sum;

	int razhodKola = (distance*razhod) / 100;
	double totalRazhod = razhodKola * gorivoZaLitur;

	if (totalRazhod <= sum)
	{
		cout << "You can take a trip. " << fixed << setprecision(2) << sum - totalRazhod << " money left." << endl;

	}
	else 
	{
		float razpredelenie = (float)sum / (float)5;

		cout << "Sorry, you cannot take a trip. Each will receive " << fixed << setprecision(2) << razpredelenie << " money." << endl;
	}


}