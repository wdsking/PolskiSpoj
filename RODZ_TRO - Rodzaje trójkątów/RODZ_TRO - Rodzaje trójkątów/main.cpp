#include <iostream>
#include <algorithm>
#include <string>
#include <math.h>
using namespace std;
int compare(const void * a, const void * b)
{
	return (*(int*)a - *(int*)b);
}
string TriangleType(int* arr)
{
	if (arr[0] == 0 || arr[1] == 0 || arr[2] == 0) return "brak";
	if (arr[0] + arr[1] <= arr[2]) return "brak";
	double l = (arr[0] * arr[0] + arr[1] * arr[1] - arr[2] * arr[2]);
	double m = (2 * arr[0] * arr[1]);
	int cosinus = acos(l / m)*180/3.14;
	if (cosinus > 90) return "rozwartokatny";
	if (cosinus == 90) return "prostokatny";
	if (cosinus < 90) return "ostrokatny";
}
int main()
{
	int a, b, c;
	int arr[3];
	while (cin >> a >> b >> c)
	{
		arr[0] = a;
		arr[1] = b;
		arr[2] = c;
		qsort(arr,3,sizeof(int),compare);
		cout << TriangleType(arr) << endl;
	}
	return 0;
}