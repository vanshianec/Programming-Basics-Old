// Ex1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "string"
#include "iomanip"
#include "cmath"
using namespace std;
int main()
{
	int number_of_students;
	cin >> number_of_students;
	double score;
	
	double sum1 = 0;
	double sum2 = 0;
	double sum3 = 0;
	double sum4 = 0;
	double sum5 = 0;



	
	for (int i = 1; i <= number_of_students; i++)
	{
		cin >> score;
		 if (score < 22.5)
		{
			sum1++;
		}
		else if (score >= 22.5 && score < 40.5)
		{
			sum2++;
		}
		else if (score >=40.5 && score <58.5)
		{
			sum3++;
		}
		else if (score >=58.5 && score < 76.5)
		{
			sum4++;
		}
		else if (score >=76.5 && score <=100 )
		{
			sum5++;
		}
		
	}
	double total1 = sum1 / number_of_students * 100;
	double total2 = sum2 / number_of_students * 100;
	double total3 = sum3 / number_of_students * 100;
	double total4 = sum4 / number_of_students * 100;
	double total5 = sum5 / number_of_students * 100;
	cout << fixed << setprecision(2) << total1 << "% poor marks" << endl;
	cout << fixed << setprecision(2) << total2 << "% satisfactory markss" << endl;
	cout << fixed << setprecision(2) << total3 << "% good marks" << endl;
	cout << fixed << setprecision(2) << total4 << "% very good marks" << endl;
	cout << fixed << setprecision(2) << total5 << "% excellent marks" << endl;




	
	}
	

   


