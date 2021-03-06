// FR_02_06 - BMI.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <string>
#include <iostream>
#include <vector>
using namespace std;
vector<string> underweight;
vector<string> correctweight;
vector<string> overweight;
void BMI(string name,float a, float b)
{
	b = b / 100;
	float bmi = a / (b * b);
	if (bmi < 18.5)
	{
		underweight.push_back(name);
		return;
	}
	if (bmi >= 18.5 && bmi < 25)
	{
		correctweight.push_back(name);
		return;
	}
	if (bmi >= 25)
	{
		overweight.push_back(name);
		return;
	}
}
int main()
{
	int tests;
	cin >> tests;

	for (int i = 0; i < tests; i++)
	{
		string name;
		float weight = 0, height=0;
		cin >> name >> weight >> height;
		BMI(name, weight, height);
	}
	cout << "niedowaga" << endl;
	for (int i = 0; i < underweight.size(); i++)
	{
		cout << underweight[i] << endl;
	}
	cout << endl;
	cout << "wartosc prawidlowa" << endl;
	for (int i = 0; i < correctweight.size(); i++)
	{
		cout << correctweight[i] << endl;
	}
	cout << endl;
	cout << "nadwaga" << endl;
	for (int i = 0; i < overweight.size(); i++)
	{
		cout << overweight[i] << endl;
	}

    return 0;
}

