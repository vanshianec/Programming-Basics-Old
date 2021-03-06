// ConsoleApplication21.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "string"
#include "iomanip"
#include "cmath"
using namespace std;

int main()
{
	double time_of_first_brother, time_of_second_brother, time_of_third_brother, time_of_father;
	cin >> time_of_first_brother >> time_of_second_brother >> time_of_third_brother >> time_of_father;
	double total_time = 1 / (1 / time_of_first_brother + 1 / time_of_second_brother + 1 / time_of_third_brother);
	double rest_time = total_time + total_time*0.15;
	double time_left = time_of_father - rest_time;
	if (time_left > 0)
	{
		cout << "Yes, there is a surprise - time left - " << floor(time_left) << " hours." << endl;
	}
	else 
	{
		time_left=abs(time_left);
		cout << "No, there isn’t a surprise - shortage of time - " << ceil(time_left) << " hours." << endl;
	}
}

