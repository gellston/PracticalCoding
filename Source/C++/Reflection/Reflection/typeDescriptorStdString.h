#pragma once


#ifndef REFLECTION_TYPE_DESCRIPTOR_STD_STRING
#define REFLECTION_TYPE_DESCRIPTOR_STD_STRING

#include "reflectAPI.h"
#include "typeDescriptor.h"
#include "primitiveDescriptor.h"

#include <string>
#include <vector>


namespace reflect {
	class typeDescriptorStdString : public typeDescriptor {

	public:

#pragma region Constructor
		REFLECT_API typeDescriptorStdString();
#pragma endregion

#pragma region Destructor
		REFLECT_API ~typeDescriptorStdString();
#pragma endregion

#pragma region Public Functions
		REFLECT_API void dump(const void* obj, int indentLevel) override;
#pragma endregion


	};

}

PRIMITIVE_DESCRIPTOR(typeDescriptorStdString, std::string)

#endif