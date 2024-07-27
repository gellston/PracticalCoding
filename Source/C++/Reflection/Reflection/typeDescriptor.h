#pragma once


#ifndef REFLECTION_TYPE_DESCRIPTOR
#define REFLECTION_TYPE_DESCRIPTOR

#include "reflectAPI.h"

#include <typeinfo>
#include <string>

namespace reflect {
	class typeDescriptor {

	public:


#pragma region Constructor
		REFLECT_API typeDescriptor(std::string name, std::size_t size);
#pragma endregion

#pragma region Destructor
		REFLECT_API virtual ~typeDescriptor();
#pragma endregion

#pragma region Private Property
		std::string name;
		std::size_t size;
#pragma endregion

#pragma region Public Functions
		REFLECT_API virtual std::string getFullName() const;
		REFLECT_API virtual void dump(const void* obj, int indentLevel = 0) {};
#pragma endregion
	};
}



#endif