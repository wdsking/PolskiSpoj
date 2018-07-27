// BAJTST - Bajtockie Święto Trójkąta.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <math.h>
#include <iomanip>
using namespace std;
double Heron(double a, double b, double c)
{
	double p = (a + b + c) / 2;
	return sqrt(p*(p - a)*(p - b)*(p - c));
}
int main()
{
	ios::sync_with_stdio(false);
	cout.setf(ios::fixed);
	int testsCount;
	cin >> testsCount;
	float currentUsage = 0;
	for (int i = 0; i < testsCount; i++)
	{
		float n, k;
		cin >> n >> k;
		for (int x = 0; x < n; x++)
		{


			int a, b, c;
			cin >> a >> b >> c;
			if (a + b < c || a + c < b || b + c < a)
			{
				continue;
			}
			else
			{
				currentUsage += Heron(a, b, c);
			}
		}
		cout << setprecision(0) <<((currentUsage*k)/10) << endl;
		currentUsage = 0;
	}
    return 0;
}

