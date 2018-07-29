// KC003 - Nierówność trójkąta.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;
int isTriangle(float a, float b, float c)
{
	if (a < 0 || b < 0 || c < 0) return 0;
	if (a + b < c || a + c < b || b + c < a)
	{
		return 0;
	}
	else return 1;
}

int main()
{
	float a, b, c;
	while (cin >> a >> b >> c)
	{
		cout << isTriangle(a, b, c) << endl;
	}
    return 0;
}

