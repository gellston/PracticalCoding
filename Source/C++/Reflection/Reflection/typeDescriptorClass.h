#pragma once


#ifndef REFLECTION_TYPE_DESCRIPTOR_CLASS
#define REFLECTION_TYPE_DESCRIPTOR_CLASS

#include "reflectAPI.h"
#include "typeDescriptor.h"

#include <string>
#include <vector>


namespace reflect {
	class typeDescriptorClass : public typeDescriptor{

	public:

#pragma region Member Struct
		struct member {
			std::string name;
			std::size_t offset;
			typeDescriptor* type;
		};
#pragma endregion

#pragma region Constructor
		REFLECT_API typeDescriptorClass(void (*init)(typeDescriptorClass*));
		REFLECT_API typeDescriptorClass(std::string name, std::size_t size, const std::initializer_list<member>& init);
#pragma endregion

#pragma region Destructor
		REFLECT_API ~typeDescriptorClass();
#pragma endregion

#pragma region Public Property
		std::vector<member> members;
#pragma endregion

#pragma region Public Functions
		REFLECT_API virtual void dump(const void* obj, int indentLevel) override;
#pragma endregion


	};

}

#endif