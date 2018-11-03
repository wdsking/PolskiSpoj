#include <iostream>
#include <string>
using namespace std;

int main()
{
	string num;
	
	while (cin >> num)
	{
		if (num == "0")break;
		int sum = 0;
		if (num[num.length() - 1] == '0' || num[num.length() - 1] == '5')
		{
			for (int i = 0; i < num.length(); i++)
			{
				sum += (int)num[i];
			}
			if (sum % 3 == 0)
			{
				cout << "TAK" << endl;
			}
			else
			{
				cout << "NIE" << endl;
			}
		}
		else cout << "NIE" << endl;
	}
	return 0;
}