// AL_03_08 - Prezent.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <algorithm>
#include <vector>
using namespace std;

int main()
{
	int a;
	vector<int> doubles;
	while (cin >> a && a != 0)
	{
		doubles.push_back(a);
	}
	sort(doubles.begin(), doubles.end());
	
	if (doubles[doubles.size() - 1] == doubles[0])
	{
		cout << doubles[0];
	}
	else
	{
		for (int i = doubles.size() - 1; i >= 0; i--)
		{
			if (doubles[i] != doubles[doubles.size() - 1])
			{
				cout << doubles[i] << endl;
				break;
			}
		}
	}
	return 0;
}

