#pragma once


#ifndef PIMPL_API_EXPORT_HEADER
#define PIMPL_API_EXPORT_HEADER


#if PIMPL_API_EXPORT

#define PIMPL_API __declspec(dllexport)

#else

#define PIMPL_API __declspec(dllimport)

#endif


#endif