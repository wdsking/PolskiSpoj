#include <iostream>
#include <string>
using namespace std;


int main()
{
	string line;
	int counter = 0;
	while (cin >> line)
	{
		for (int i = 0; i < line.length(); i++)
		{
			if (i + 2<line.length())
			{
				if (line[i] == '.' && line[i + 1] == '.' && line[i + 2] == '.')
				{
					counter++;
					i += 2;
					continue;
				}
			}
			if (line[i] == '.' || line[i] == '?' || line[i] == '!')
			{
				counter++;
			}
		}
	}
	cout << counter << endl;
	return 0;
}

