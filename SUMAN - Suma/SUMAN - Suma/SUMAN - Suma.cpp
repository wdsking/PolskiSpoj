// SUMAN - Suma.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;
int main(int a,int b)
{
	for (int i = 0; i < 10; i++)
	{
		b = 0;
		cin >> a;
		for (int c = 1; c <= a; c++)
		{
			b += c;
		}
		cout << b << endl;
	}
    return 0;
}

