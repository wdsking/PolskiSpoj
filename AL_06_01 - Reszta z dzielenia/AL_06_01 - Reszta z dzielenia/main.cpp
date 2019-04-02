#include <iostream>
#include <stdlib.h>
using namespace std;

int FindRest(int k, int b)
{




	if (k >= 0 && b > 0)
	{

		return k % b;
	}



	if (k >= 0 && b < 0)
	{

		int temp = 0;
		while (temp*b <= k)
		{
			for (int r = 0; r < abs(b); r++)
			{
				if (temp*b + r == k)
				{
					return r;
				}
			}
			temp--;

		}
		for (int r = 0; r < abs(b); r++)
		{
			if (temp*b + r == k)
			{
				return r;
			}
		}
	}

	if (k <= 0 && b > 0)
	{
		int temp = 0;

		while (temp*b >= k)
		{

			for (int r = 0; r < abs(b); r++)
			{
				if (temp*b + r == k)
				{
					return r;
				}
			}
			temp--;

		}
		for (int r = 0; r < abs(b); r++)
		{
			if (temp*b + r == k)
			{
				return r;
			}
		}


	}
	if (k <= 0 && b < 0)
	{
		int temp = 0;
		while (temp*b >= k)
		{

			for (int r = 0; r < abs(b); r++)
			{
				if (temp*b + r == k)
				{
					return r;
				}
			}

			temp++;
		}
		for (int r = 0; r < abs(b); r++)
		{
			if (temp*b + r == k)
			{
				return r;
			}
		}

	}


}
int main()
{
	int tests;
	cin >> tests;
	for (int i = 0; i < tests; i++)
	{
		int k, b;
		cin >> k >> b;

		cout << FindRest(k, b) << endl;
	}

	return 0;
}