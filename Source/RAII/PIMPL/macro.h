#pragma once


#define HV_ERROR(variable, message, code) \
std::string temp = ""; \
temp += message; \
temp += ":"; \
temp += __FUNCTION__; \
temp += ":"; \
temp += __LINE__; \
hv::hvexception variable(temp, code); \




#ifndef HV_EXPORT
#define HV_API __declspec(dllimport)

#else
#define HV_API __declspec(dllexport)

#endif