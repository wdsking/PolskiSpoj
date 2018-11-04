#include <iostream>
#include <string>
using namespace std;
int main()
{
	ios_base::sync_with_stdio(0);
	string line;
	int* ascii = new int[256];
	while (getline(cin,line))
	{
		for (int i = 0; i < line.length(); ++i)
		{
			ascii[(unsigned char)line[i]]++;
		}
		ascii[10]++;
	}
	for (int i = 0; i < 256; ++i)
	{
		if (ascii[i] != 0)
		{
			cout << i << " " << ascii[i] << "\n";
		}
	}
	return 0;
}