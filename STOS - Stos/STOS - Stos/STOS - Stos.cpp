// STOS - Stos.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{

	const int tablesize = 10;
	int table[tablesize];
	for (int i = 0; i < tablesize; i++)
	{
		table[i] == 100;
	}
	int index = 0;
	char sign;
	float value;

	while (cin >> sign)
	{
		if (sign == '+')
		{
		cin >> value;
		if (index == tablesize)
		{
			cout << ":(" << endl;
		}
		else
		{
			int tmp;
			for (int i = index; i >= 0; i--)
			{
				table[i + 1] = table[i];
			}
			table[0] = value;
			index++;
			cout << ":)" << endl;
		}
	
		}
		if (sign == '-')
		{
			if (index > 0)
			{
				cout << table[0] << endl;
				table[0] == 100;
				for (int i = 0; i < index; i++)
				{
					table[i] = table[i + 1];
				}
				index--;
			}
			else
			{
				cout << ":(" << endl;
			}

		}
	}
    return 0;
}

