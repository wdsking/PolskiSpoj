// PP0602A - Parzyste nieparzyste.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <vector>
using namespace std;

int main()
{
	int testsCount = 0;
	cin >> testsCount;
	
	for (int i = 0; i < testsCount; i++)
	{

		int n;
		cin >> n;
		vector<int> numbers;

		for (int  a = 0; a < n; a++)
		{
			int num;
			cin >> num;
			numbers.push_back(num);
		}
		for (int a = 1; a < n; a+=2)
		{
			cout << numbers[a]<< " ";
		}
		for (int a = 0; a < n; a += 2)
		{
			cout << numbers[a] << " ";
		}
		cout << endl;
	}

    return 0;
}

