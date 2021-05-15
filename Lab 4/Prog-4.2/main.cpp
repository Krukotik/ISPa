#include "main.h"
#include "pch.h"

extern "C"  __declspec(dllexport) int __cdecl Fibanachi(int count)
{
	int number_now = 1;
	int  number_previouse = 0;
	while (number_now != count)
	{
		int count = number_now;
		number_now += number_previouse;
		number_previouse = count;
	} 
	return number_previouse;
}

extern "C" int __declspec(dllexport) __stdcall Factorial(int fact)
{
	int multiplay = 0, i;
	for (i = 1; i <= fact; i++)
	{
		multiplay *= i;
	}
	if (multiplay == fact)
		return multiplay;
}