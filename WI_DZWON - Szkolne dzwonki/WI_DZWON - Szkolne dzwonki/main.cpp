#include <iostream>
#include <string>
#include <vector>

using namespace std;
void Display(int hour, int minutes)
{
	string s = "";
	if (hour < 10)
	{
		s += "0" + to_string(hour);
	}
	else s += to_string(hour);
	s += ":";
	if (minutes < 10)
	{
		s += "0" + to_string(minutes);
	}
	else s += to_string(minutes);
	cout<< s;
}
void AddMinutes(int &minutes, int &hours,int amount)
{
	minutes += amount;
	if (minutes >= 60)
	{
		int hoursToAdd = minutes / 60;
		hours += hoursToAdd;
		if (hours >= 24)
		{
			hours %= 24;
		}
		minutes %= 60;
	}
	Display(hours, minutes);
}

int main()
{
	string s;
	cin >> s;
	int hours;
	int minutes;
	vector<int> breaks;
	int breakTime;
	hours = stoi(s.substr(0, 2));
	minutes = stoi(s.substr(3, 2));
	while (cin >> breakTime)
	{
		breaks.push_back(breakTime);
	}
	Display(hours, minutes);
	for (int i = 0; i < breaks.size(); i++)
	{
		cout << ",";
		AddMinutes(minutes, hours, 45);
		cout << ",";
		AddMinutes(minutes, hours, breaks[i]);		
	}
	cout << ",";
	AddMinutes(minutes, hours, 45);
	return 0;
}