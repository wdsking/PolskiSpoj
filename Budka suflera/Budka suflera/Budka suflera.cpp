// Budka suflera.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <algorithm>
#include <vector>
#include <string>

using namespace std;
vector<string> Split(string s)
{
	vector<string> words;
	int index = 0;
	for (int i = 0; i < s.length(); i++)
	{
		if (s[i] == ' ' || i==s.length()-1)
		{
			words.push_back(s.substr(index, i-index));
			s = s.substr(i+1, s.length());
			index = i+1;
		}
	}
	return words;
}
int main()
{
	vector<string> text;
		vector<string> text2;
		vector<string> missed;
		string texcik;
		getline(cin,texcik);

		text = Split(texcik);
	for (int i = 0; i < text.size(); i++)
	{
		if (text2.size()>0)
		{
			if (text2.front() == text[i])
			{
				text2.erase(text2.begin());
			}
			else
			{
				missed.push_back(text[i]);
			}
		}
		else
		{
			missed.push_back(text[i]);
		}
	}

	if (missed.size() == 0)
	{
		cout << "0";
		return 0;
	}
	else
	{
		
		sort(missed.begin(), missed.end());
		cout << missed.size();

		for (int i = 0; i < missed.size(); i++)
		{
			cout << missed[i];
			if (i != missed.size() - 1)
			{
				cout << "\n";
			}
		}
	}
    return 0;
}

