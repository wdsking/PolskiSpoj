// ETI06F1 - Pole pewnego kola.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <math.h>
using namespace std;

int main()
{
	double r = 0, d = 0;
	cin >> r;
	cin >> d;
	cout.setf(ios::fixed);
	cout << (((r*r) - ((d*d) / 4))* 3.14159265358979323846);
	return 0;
}

