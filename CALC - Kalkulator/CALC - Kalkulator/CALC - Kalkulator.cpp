// CALC - Kalkulator.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;
int main()
{
	char sign;
	int a, b;
	while (cin >> sign >> a >> b)
	{
		switch (sign)
		{
		case '+':
		{
			cout << a + b;
			break;
		}
		case '-':
		{
			cout << a - b;
			break;
		}
		case '*':
		{
			cout << a * b;
			break;
		}
		case '/':
		{
			cout << a / b;
			break;
		}
		case '%':
		{
			cout << a % b;
			break;
		}
		}
		cout << endl;
	}
	return 0;
}

  


