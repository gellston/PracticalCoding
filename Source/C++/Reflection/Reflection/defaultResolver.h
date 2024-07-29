#pragma once

#ifndef REFLECTION_DEFAULT_RESOLVER
#define REFLECTION_DEFAULT_RESOLVER

#include "typeDescriptor.h"
#include "primitiveDescriptor.h"
#include "typeDescriptorInt.h"
#include "typeDescriptorDouble.h"
#include "typeDescriptorStdString.h"

#include <type_traits>

namespace reflect {
	class defaultResolver {
	public:
		template<typename T> static char func(decltype(&T::reflection));
		template<typename T> static double func(...);

		template<typename T>
		struct isReflected {
			enum {
				value = sizeof(func<T>(nullptr)) == sizeof(char)
			};
		};

		template<typename T, typename std::enable_if<isReflected<T>::value, int>::type = 0 >
		static typeDescriptor* get() {
			return &T::reflection;
		}

		template<typename T, typename std::enable_if<!isReflected<T>::value, int>::type = 0>
		static typeDescriptor* get() {
			return getPrimitiveDescriptor<T>();
		}
	};

}

#endif