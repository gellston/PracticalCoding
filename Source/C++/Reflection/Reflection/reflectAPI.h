#pragma once


#ifndef REFLECT_EXPORT
#define REFLECT_API __declspec(dllimport)
#else
#define REFLECT_API __declspec(dllexport)
#endif