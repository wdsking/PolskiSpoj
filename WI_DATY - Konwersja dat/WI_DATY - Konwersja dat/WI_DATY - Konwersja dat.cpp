// WI_DATY - Konwersja dat.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <math.h>
using namespace std;
int BinToDec(long long n)
{
	int decimalNumber = 0, i = 0, remainder;
	while (n != 0)
	{
		remainder = n % 10;
		n /= 10;
		decimalNumber += remainder * pow(2, i);
		++i;
	}
	return decimalNumber;
}
string DecToBin(int number)
{
	if (number == 0) return "0";
	if (number == 1) return "1";

	if (number % 2 == 0)
		return DecToBin(number / 2) + "0";
	else
		return DecToBin(number / 2) + "1";
}
int main()
{
	string binaryInput = "";
	cin >> binaryInput;
	if (binaryInput.size() == 16)
	{
		int year = 1980, month = 0, day = 0;
		if (binaryInput.length() > 16)
		{
			cout << "ERROR";
			return 0;
		}


		long long num = stoll(binaryInput.substr(0, 7));
		year += BinToDec(num);
		num = stoll(binaryInput.substr(7, 4));
		month += BinToDec(num);
		if (month > 12 || month == 0)
		{
			cout << "ERROR";
			return 0;
		}
		num = stoll(binaryInput.substr(11, 5));
		day += BinToDec(num);
		if (day > 31 || day == 0)
		{
			cout << "ERROR";
			return 0;
		}
		string y, m, d;
		y = to_string(year);
		if (month < 10)
		{
			m = "0" + to_string(month);
		}
		else m = to_string(month);
		if (day < 10)
		{
			d = "0" + to_string(day);
		}
		else d = to_string(day);

		cout << y << "-" << m << "-" << d;
	}
	else
	{
		int year = stoi(binaryInput.substr(0, 4));
		year-= 1980;
		int month = stoi(binaryInput.substr(5, 2));
		int day = stoi(binaryInput.substr(8, 2));
		string y = DecToBin(year);
		string m = DecToBin(month);
		string d = DecToBin(day);
		string zeros = "";
		if (y.length() != 7)
		{
			for (int i = 0; i < 7 - y.length(); i++)
			{
				zeros += "0";
			}
		}
		y = zeros + y;
		zeros = "";
		if (m.length() != 4)
		{
			for (int i = 0; i < 4 - m.length(); i++)
			{
				zeros += "0";
			}
		}
		m = zeros + m;
		zeros = "";
		if (d.length() != 5)
		{
			for (int i = 0; i < 5 - d.length(); i++)
			{
				zeros += "0";
			}
		}
		d = zeros + d;

		string bin = y + m + d;
		cout << bin << endl;
	}
    return 0;
}

