#include <iostream>
#include <string>
#include <vector>
using namespace std;
class Run
{
public:
	int time5;
	int time10;
	int time15;
	int time20;
	int total;
	int expected;
	Run()
	{

	}
};

int main()
{
	ios_base::sync_with_stdio(0);
	int tests;
	cin >> tests;
	vector<Run> runs;
	for (int i = 0; i < tests; ++i)
	{
		Run r;
		for (int a = 0; a < 6; ++a)
		{
			string time;
			cin >> time;
			int hours, minutes, seconds;
			hours = stoi(time.substr(0, 2));
			minutes = stoi(time.substr(3, 2));
			seconds = stoi(time.substr(6, 2));
			int timeInSeconds = hours * 3600 + minutes * 60 + seconds;	
			if (a == 0) r.time5 = timeInSeconds;
			if (a == 1) r.time10 = timeInSeconds;
			if (a == 2) r.time15 = timeInSeconds;
			if (a == 3) r.time20 = timeInSeconds;
			if (a == 4) r.total = timeInSeconds;
			if (a == 5) r.expected = timeInSeconds;

		}
		runs.push_back(r);
	}
	int negativeSplitters = 0;
	int negativeAchieved = 0;
	int others = 0;
	int othersAchieved = 0;
	for (int i = 0; i < tests; ++i)
	{
		int diff05 = runs[i].time5;
		int diff510 = runs[i].time10 - runs[i].time5;
		int diff1015 = runs[i].time15 - runs[i].time10;
		int diff1520 = runs[i].time20 - runs[i].time15;
		int last = runs[i].total - runs[i].time20;
		if (diff05 >= diff510 && diff510 >= diff1015 && diff1015 >= diff1520 && diff1520 >= last)
		{
			if (diff05 > diff1520)
			{
				negativeSplitters++;
				if (runs[i].expected > runs[i].total)
				{
					negativeAchieved++;
				}
			}
			else
			{			
				others++;
				if (runs[i].expected > runs[i].total)
				{
					othersAchieved++;
				}
			}
		}
		else
		{
			others++;
			if (runs[i].expected > runs[i].total)
			{
				othersAchieved++;
			}
		}
	}
	cout << negativeAchieved << "/" << negativeSplitters << " " << othersAchieved << "/" << others;
	return 0;
}