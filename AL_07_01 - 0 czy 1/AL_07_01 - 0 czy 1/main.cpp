#include <iostream>
#include <vector>
#include <string>

using namespace std;
int FindFirstOccurance(vector<char> signs, char sign)
{
	for (int i = 0; i < signs.size(); i++)
	{
		if (signs[i] == sign) return i;
	}
	return -1;
}
int main()
{
	ios_base::sync_with_stdio(0);
	vector<int> nums;
	vector<char> signs;
	int tests = 0;
	cin >> tests;
	for (int i = 0; i < tests; ++i)
	{
		string num;
		char sign;
		while (true)
		{
			cin >> num;
			cin >> sign;
			if (stoi(num.substr(num.length()-1,1))%2== 0) nums.push_back(0); else nums.push_back(1);			
			if (sign == '=') break; 
			signs.push_back(sign);
		}
		int indexOfMultiplier = FindFirstOccurance(signs, '*');
		while (indexOfMultiplier != -1)
		{
			nums[indexOfMultiplier] *= nums[indexOfMultiplier + 1];
			nums.erase(nums.begin() + indexOfMultiplier + 1);
			signs.erase(signs.begin() + indexOfMultiplier);
			indexOfMultiplier = FindFirstOccurance(signs, '*');
		}
		int counter = 0;
		for (int a = 0; a < nums.size(); a++)
		{
			if (nums[a] == 1) counter++;
		}

		string result = counter % 2 == 0 ? "TAK" : "NIE";

		cout << result << "\n";
		nums.clear();
		signs.clear();
	}
	return 0;
}