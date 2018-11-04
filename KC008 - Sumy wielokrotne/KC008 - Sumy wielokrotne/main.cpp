#include <iostream>
using namespace std;

int main()
{
	long long num;
	long long totalSum = 0;
	long long localSum = 0;
	while (cin >> num)
	{
		
		if (num == 0)
		{
			cout << localSum << endl;
			totalSum += localSum;
			localSum = 0;
		}
		else
		{
			localSum += num;
		}
	}
	cout << totalSum << endl;
	return 0;
}