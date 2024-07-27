#pragma once

#include "typeDescriptor.h"
#include "typeDescriptorClass.h"


#define REFLECT() \
static reflect::typeDescriptorClass reflection;\
static void initReflection(reflect::typeDescriptorClass*);

#define REFLECT_CLASS_BEGIN(type)\
reflect::typeDescriptorClass type::reflection(type::initReflection);\
void node::initReflection(reflect::typeDescriptorClass* typeDesc) {\
	using T = type;\
	typeDesc->name = #type;\
	typeDesc->size = sizeof(T);\
	typeDesc->members = {\


#define REFLECT_CLASS_END() \
	};\
}\


#define REFLECT_CLASS_MEMBER(name)\
{#name, offsetof(T, name), nullptr},