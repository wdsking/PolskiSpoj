#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;


int main()
{
	int t;
	cin >> t;
	vector<long long> numbers;
	for (int i = 0; i < t; i++)
	{
		int num;
		cin >> num;
		numbers.push_back(num);
	}
	long long localMax;
	long long globalMax = localMax = numbers[0];
	for (int i = 1; i < t; i++)
	{
		localMax = max(numbers[i], localMax + numbers[i]);
		globalMax = max(globalMax, localMax);
	}
	if (globalMax < 0) globalMax = 0;
	cout << globalMax;
	return 0;
}