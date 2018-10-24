#include <iostream>
#include <math.h>
#include <algorithm>
using namespace std;

int main()
{
	int t;
	cin >> t;
	for (int i = 0; i < t; i++)
	{
		double x, y, z;
		cin >> x >> y >> z;
		double result = ((x + y) - (z * y)) / (z - 1);
		cout << round(abs(result) * 12) << endl;
	}
	return 0;

}