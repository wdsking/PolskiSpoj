// SUMA - Suma.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <vector>
using namespace std;
int main()
{
	vector<int> numbers;
	int num;
	while (cin >> num)
	{
		numbers.push_back(num);
		int sum=0;
		for (int i = 0; i < numbers.size(); i++)
		{
			sum += numbers[i];
		}
		cout << sum << endl;
	}
    return 0;
}

