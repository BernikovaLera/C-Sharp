#pragma once
#ifdef MYDLL_EXPORTS
#define MYDLL_API __declspec(dllexport) 
#else
#define MYDLL_API __declspec(dllimport) 
#endif
extern "C" MYDLL_API double Knowledge(int count_rate, int amount);
extern "C" MYDLL_API int Count(int rate);