// JSUMDUZE - Dodawanie.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <vector>
using namespace std;


int main()
{
	vector<int> num1;
	vector<int> num2;
	int tests;
	int index = 0;
	cin >> tests;
	for (int i = 0; i < tests; i++)
	{
		string number1;
		string number2;
		cin >> number1 >> number2;
		for (int a = 0; a < number1.length(); a++)
		{
			if (a % 17 == 0)
			{
				num1.push_back(number1.substr(index, a));
				num2.push_back(number2.substr(index, a));

			}
		}
	}
	

    return 0;
}

