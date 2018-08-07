// ROWNANIE - Równanie kwadratowe.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	float a, b, c;
	while (cin >> a >> b >> c)
	{
		float delta = b * b - (4 * a*c);
		if (delta > 0)
		{
			cout << 2 << endl;
		}
		if (delta == 0)
		{
			cout << 1 << endl;
		}
		if (delta < 0)
		{
			cout << 0 << endl;
		}
	}
    return 0;
}

