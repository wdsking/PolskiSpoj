#include <iostream>
#include <math.h>
#include <iomanip>
using namespace std;

int main()
{

	int tests;
	cin >> tests;
	for (int i = 0; i < tests; i++)
	{
		int pointsCount;
		cin >> pointsCount;

		double distance = 0;
		int lastx, lasty;
		cin >> lastx >> lasty;
		for (int a = 1; a < pointsCount; a++)
		{
			int x, y;
			cin >> x >> y;
			distance += sqrt(pow(x - lastx, 2) + pow(y - lasty, 2));
			lastx = x;
			lasty = y;
		}
		printf("%.2f", distance / 1000);
		cout << "\n";

	}
	return 0;
}