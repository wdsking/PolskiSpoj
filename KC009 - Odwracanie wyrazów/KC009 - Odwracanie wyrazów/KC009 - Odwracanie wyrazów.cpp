// KC009 - Odwracanie wyrazów.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;
int main()
{

	string word;
	while (cin >> word)
	{

		for (int i = word.length()-1; i >= 0; i--)
		{
			cout << word[i];
			if (i == 0)
			{
				cout << endl;
			}
		}
	}
    return 0;
}

