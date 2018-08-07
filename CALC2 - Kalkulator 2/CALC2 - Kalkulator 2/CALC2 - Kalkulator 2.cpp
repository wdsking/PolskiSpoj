// CALC2 - Kalkulator 2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <vector>
using namespace std;
void initVector(vector<int> &Vector)
{
	for (int i = 0; i < 10; i++)
	{
		Vector.push_back(0);
	}
}
int main()
{
	vector<int> memory;
	initVector(memory);
	char sign;
	int a, b;
	while (cin >> sign >> a >> b)
	{
		switch (sign)
		{
		case '+':
		{
			cout << memory[a] + memory[b] << endl;
			break;
		}
		case '-':
		{
			cout << memory[a] - memory[b] << endl;
			break;
		}
		case '*':
		{
			cout << memory[a] * memory[b] << endl;
			break;
		}
		case '/':
		{
			cout << memory[a] / memory[b] << endl;
			break;
		}
		case '%':
		{
			cout << memory[a] % memory[b] << endl;
			break;
		}
		case 'z':
		{
			memory[a] = b;
			break;
		}
		}
	}
    return 0;
}

