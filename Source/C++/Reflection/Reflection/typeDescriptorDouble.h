#pragma once


#ifndef REFLECTION_TYPE_DESCRIPTOR_DOUBLE
#define REFLECTION_TYPE_DESCRIPTOR_DOUBLE

#include "reflectAPI.h"
#include "typeDescriptor.h"
#include "primitiveDescriptor.h"

#include <string>
#include <vector>

namespace reflect {
	class typeDescriptorDouble : public typeDescriptor {

	public:

#pragma region Constructor
		REFLECT_API typeDescriptorDouble();
#pragma endregion

#pragma region Destructor
		REFLECT_API ~typeDescriptorDouble();
#pragma endregion

#pragma region Public Functions
		REFLECT_API void dump(const void* obj, int indentLevel) override;
#pragma endregion


	};
}

PRIMITIVE_DESCRIPTOR(typeDescriptorDouble , double)

#endif