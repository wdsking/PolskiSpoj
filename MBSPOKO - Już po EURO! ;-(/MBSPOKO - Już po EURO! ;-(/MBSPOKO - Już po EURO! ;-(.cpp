#include "stdafx.h"
#include <iostream>
using namespace std;int main(){long a;for (int i = 0; i < 100; i++){cin >> a;if (a % 15 == 0) { cout << "SPOKOKOKO\n"; }else if (a % 3 == 0) { cout << "KOKO\n"; }else if (a % 5 == 0) { cout << "SPOKO\n"; }else cout << a << endl;}return 0;}