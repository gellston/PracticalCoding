#pragma once
#ifndef RET_TYPE_RESOLVER
#define RET_TYPE_RESOLVER

#include <string>

namespace hv {
	class retTypeResolver {
	private:
#pragma region Private Property
		double data = 0;
#pragma endregion

	
	public:
#pragma region Constructor
		retTypeResolver(double data);
		retTypeResolver(int data);
#pragma endregion

#pragma region Type Casting Operator
		operator double();
		operator int();
		operator std::string();
#pragma endregion

	};
}

#endif