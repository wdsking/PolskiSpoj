// BEZPRZEC - Czy potrafisz nie uzyc srednika.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>


int main(int a,int b)
{
	//1st method
	if (scanf_s("%d",&a) + scanf_s("%d", &b)) 
	{
		if (printf("%d", a + b)) {}
	}
	//2nd method
	/*if (std::cin >> a)
	{
		if (std::cin >> b)
		{
			if (std::cout << a + b) {}
		}
	}*/

}

