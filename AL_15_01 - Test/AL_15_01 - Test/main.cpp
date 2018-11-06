#include <iostream>
#include <string>
using namespace std;
int main()
{
	ios_base::sync_with_stdio(0);
	string s1, s2, s3;
	cin >> s1 >> s2 >> s3;
	int points = 0;
	for (int i = 0; i < s1.length(); ++i)
	{
		if (s1[i] == s2[i] && s2[i] == s3[i]) continue;
		if (s1[i] != s2[i] || s1[i] != s3[i])
		{
			if (s2[i] == s3[i])
			{
				points += 2;
			}else points++;
		}	
	}
	cout << points;
	return 0;
}