// JHTMLLET - Tagi HTML.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <vector>
#include <ctype.h>
#include <string>
using namespace std;
int main()
{
	vector<string> text;
	string t;
	while (getline(cin,t))
	{
		text.push_back(t);
	}
	for (int i = 0; i < text.size(); i++)
	{
		for (int a = 0; a < text[i].length(); a++)
		{
			if (text[i][a] == '<')
			{
				for (int b = a; b < text[i].length(); b++)
				{
					if (text[i][b] != '>')
					{
						text[i][b] = toupper(text[i][b]);
					}
					else
					{
						a = b;
						break;
					}
					
				}
			}
		}
		
	}
	for (int i = 0; i < text.size(); i++)
	{
		cout << text[i];
		if (i != text.size() - 1)
		{
			cout << endl;
		}
	}
    return 0;
}

