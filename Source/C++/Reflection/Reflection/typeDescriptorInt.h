#pragma once


#ifndef REFLECTION_TYPE_DESCRIPTOR_INT
#define REFLECTION_TYPE_DESCRIPTOR_INT

#include "reflectAPI.h"
#include "typeDescriptor.h"
#include "primitiveDescriptor.h"

#include <string>
#include <vector>


namespace reflect {
	class typeDescriptorInt : public typeDescriptor {

	public:

#pragma region Constructor
		REFLECT_API typeDescriptorInt();
#pragma endregion

#pragma region Destructor
		REFLECT_API ~typeDescriptorInt();
#pragma endregion

#pragma region Public Functions
		REFLECT_API void dump(const void* obj, int indentLevel) override;
#pragma endregion


	};

}

PRIMITIVE_DESCRIPTOR(typeDescriptorInt, int)

#endif