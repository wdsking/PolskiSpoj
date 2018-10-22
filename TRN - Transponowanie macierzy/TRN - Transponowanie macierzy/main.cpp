#include <iostream>
#include <vector>
using namespace std;

vector<vector<int>> GetMatrix(int rows, int columns)
{
	vector<vector<int>> matrix;
	for (int i = 0; i < rows; i++)
	{
		vector<int> row;
		for (int j = 0; j < columns; j++)
		{
			int num;
			cin >> num;
			row.push_back(num);
		}
		matrix.push_back(row);
	}
	return matrix;
}
vector<vector<int>> Transpose(vector<vector<int>> matrix, int rows, int columns)
{
	vector<vector<int>> transposedMatrix;
	for (int i = 0; i < columns; i++)
	{
		vector<int> row;
		for (int j = 0; j < rows; j++)
		{
			row.push_back(matrix[j][i]);
		}
		transposedMatrix.push_back(row);
	}
	return transposedMatrix;
}
void Display(vector<vector<int>> matrix, int rows, int columns)
{
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			cout << matrix[i][j] << " ";
			if (j == columns - 1)
			{
				cout << "\n";
			}
		}
	}
}
int main()
{
	int m;
	int n;
	cin >> m;
	cin >> n;
	vector<vector<int>> A = GetMatrix(m, n);
	vector<vector<int>> B = Transpose(A, m, n);

	Display(B, n, m);
	return 0;
}

