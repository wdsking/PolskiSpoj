// MWPZ06X - Nowa działka.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <math.h>
using namespace std;

int main()
{
	
	int tests;
	cin >> tests;
	for (int i = 0; i < tests; i++)
	{
		int a;
		cin >> a;
		cout << pow(a, 2);
		if (i != tests - 1)
		{
			cout << endl;
		}
	}
    return 0;
}

