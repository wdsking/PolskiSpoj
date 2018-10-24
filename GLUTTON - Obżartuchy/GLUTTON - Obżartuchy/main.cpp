#include <iostream>
#include <math.h>
#include <vector>
using namespace std;


int main()
{
	int t;
	cin >> t;
	int secondsInDay = 86400;
	vector<int> times;
	for (int i = 0; i < t; i++)
	{
		times.clear();
		long long N, M;
		
		cin >> N >> M;
		for (int a = 0; a < N; a++)
		{
			int time;
			cin >> time;
			times.push_back(time);
		}
		int packs = 0;
		int cookiesInDay = 0;
		for (int a = 0; a < N; a++)
		{
			cookiesInDay += secondsInDay / times[a];
		}
		packs = cookiesInDay / M;
		if (cookiesInDay%M != 0)
		{
			packs++;
		}
		cout << packs << endl;
	}
	return 0;
}