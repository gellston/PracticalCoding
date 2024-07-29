#pragma once


#ifndef REFLECTION_TYPE_RESOLVER
#define REFLECTION_TYPE_RESOLVER

#include "defaultResolver.h"

namespace reflect {
	template<typename T> struct typeResolver {
		static typeDescriptor* get() {
			return reflect::defaultResolver::get<T>();
		}
	};
}


#endif