// KC004 - Zliczanie wystąpień.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int numberToSearch = 0;
	int length = 0;
	while (cin >> numberToSearch >> length)
	{
		int counter = 0;
		for (int i = 0; i < length; i++)
		{
			int a;
			cin >> a;
			if (a == numberToSearch) counter++;
		}
		cout << counter << endl;
		counter = 0;
	}
    return 0;
}

