#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;
int compare(const void * a, const void * b)
{
	return (*(int*)a - *(int*)b);
}
int main()
{
	std::ios_base::sync_with_stdio(false);	
	int tests;
	cin >> tests;
	for (int i = 0; i < tests; ++i)
	{
		int counter = 0;
		int n, k;
		cin >> n >> k;
		int* wages = new int[n];
		int beginning = 0;
		int end = n-1;

		for (int a = 0; a < n; ++a)
		{
			cin >> wages[a];
		}
		
		qsort(wages, n,sizeof(int),compare);
		while (true)
		{
			
			if (beginning == end)
			{
				counter++;
				break;
			}

			if (wages[end] + wages[beginning] <= k)
			{
				end--;
				counter++;
				if (beginning == end)
				{					
					break;
				}
				beginning++;
			}
			else
			{
				end--;
				counter++;
			}
		}
		cout << counter << "\n";
	}

	return 0;
}