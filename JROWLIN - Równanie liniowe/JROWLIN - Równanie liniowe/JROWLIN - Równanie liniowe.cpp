// JROWLIN - Równanie liniowe.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	cout.setf(ios::fixed);
	float a, b, c;
	cin >> a >> b >> c;
	if (a == 0 && b - c == 0) cout << "NWR";
	if (a == 0 && b - c != 0) cout << "BR";
	if (a != 0)
	{
		b -= c;
		printf("%0.2lf", -b / a);
	}

    return 0;
}

