#include <iostream>
using namespace std;
int EuklidesGame(int aTokens, int bTokens)
{
	if(aTokens == bTokens)	return (aTokens + bTokens);
	while (aTokens != bTokens)
	{
		if (aTokens < bTokens)
		{
			
			bTokens -= aTokens;
	
		}
		else
		{
			aTokens -= bTokens;

		}
	} 
	return (aTokens + bTokens);
}
int main()
{
	int aTokens;
	
	int bTokens;
	
	int tests;
	cin >> tests;
	for (int i = 0; i < tests; i++)
	{
		cin >> aTokens >> bTokens;
		cout << EuklidesGame(aTokens, bTokens) << endl;
	}
}