#pragma once


#ifndef REFLECTION_PRIMITIVE_DESCRIPTOR
#define REFLECTION_PRIMITIVE_DESCRIPTOR

#include "typeDescriptor.h"

namespace reflect {
	template<typename T> static typeDescriptor* getPrimitiveDescriptor();
}

#endif


#define PRIMITIVE_DESCRIPTOR(desc, type)\
namespace reflect{\
	template<> typeDescriptor* getPrimitiveDescriptor<type>() {\
		static desc typeDesc;\
		return &typeDesc;\
	}\
}\
