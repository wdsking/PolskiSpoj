// PP0601B - Podzielność.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int testsCount;
	cin >> testsCount;
	int n, x, y;
	for (int a = 0; a < testsCount; a++)
	{
		cin >> n;
		cin >> x;
		cin >> y;
		for (int i = 1; i < n; i++)
		{
			if (i%x == 0 && i%y != 0)
			{
				cout << i << " ";
			}
		}
		cout << endl;
	}
	
    return 0;
}

