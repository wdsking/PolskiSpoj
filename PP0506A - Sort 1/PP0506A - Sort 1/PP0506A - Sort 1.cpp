#include "stdafx.h"
#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <math.h>
using namespace std;
class Point
{
public:

	string name;
	int x;
	int y;
	double magnitude;
};
struct less_than_key
{
	inline bool operator() (const Point& struct1, const Point& struct2)
	{
		return (struct1.magnitude < struct2.magnitude);
	}
};
int main()
{
	vector<Point> points;
	int testsCount;
	cin >> testsCount;
	for (int i = 0; i < testsCount; i++)
	{
		int pointsCount;
		cin >> pointsCount;
		points.clear();
		for (int a = 0; a < pointsCount; a++)
		{
			Point p;

			cin >> p.name;
			cin >> p.x;
			cin >> p.y;
			p.magnitude = sqrt(pow(p.x, 2) + pow(p.y, 2));
			points.push_back(p);

		}
		sort(points.begin(), points.end(), less_than_key());


		for (int b = 0; b < points.size(); b++)
		{
			cout << points[b].name << " " << points[b].x << " " << points[b].y << endl;
		}

		cout << endl;
	}



	return 0;

}
