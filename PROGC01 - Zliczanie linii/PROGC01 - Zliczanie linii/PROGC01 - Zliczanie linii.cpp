// PROGC01 - Zliczanie linii.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <vector>
#include <string>
using namespace std;


int main()
{
	vector<string> inputs;
	string text;
	while (getline(cin, text))
	{
		inputs.push_back(text);
	}
	cout << inputs.size();
    return 0;
}

