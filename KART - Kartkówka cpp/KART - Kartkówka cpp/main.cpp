#include <iostream>
using namespace std;


int main()
{
	ios_base::sync_with_stdio(0);
	int tests;
	cin >> tests;
	for (int i = 0; i < tests; ++i)
	{
		int n;
		cin >> n;
		int zeros = 0;
		for(int a=5;n/a>=1;a*=5)
		{
			zeros += n / a;
		}
		cout << zeros << "\n";
	}

	return 0;
}