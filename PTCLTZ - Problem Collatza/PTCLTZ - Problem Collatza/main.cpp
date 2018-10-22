#include <iostream>
using namespace std;

int Collatz(int xn,int &n)
{
	
	if (xn == 1) return n;
	if (xn % 2 == 0)
	{
		n++;
		return Collatz(xn / 2,n);
	}
	else
	{
		n++;
		return Collatz(3 * xn + 1,n);
	}
}

int main()
{
	int t, s, n;
	cin >> t;
	for (int i = 0; i < t; i++)
	{
		n = 0;
		cin >> s;
		cout << Collatz(s,n) << endl;

	}
	return 0;
}