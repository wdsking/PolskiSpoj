// PICIRC - Punkty w okręgu.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;
char WhereIsPoint(int x0,int y0, int r,int x, int y)
{
	int leftSide = pow(x - x0, 2) + pow(y - y0, 2);
	int rSquared = pow(r, 2);
	if (leftSide == rSquared)
	{
		return 'E';
	}
	if (leftSide < rSquared)
	{
		return 'I';
	}
	if (leftSide > rSquared)
	{
		return 'O';
	}
}
int main()
{
	int x0, y0, r;
	cin >> x0 >> y0 >> r;
	int points;
	cin >> points;
	for (int i = 0; i < points; i++)
	{
		int x, y;
		cin >> x >> y;
		cout << WhereIsPoint(x0, y0, r, x, y) << endl;

	}
    return 0;
}

