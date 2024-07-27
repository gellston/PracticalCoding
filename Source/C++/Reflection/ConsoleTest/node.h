#pragma once

#ifndef NODE
#define NODE

#include <reflection.h>

class node {

	REFLECT()

private:
	std::string key;
	int value;

public:



};

reflect::typeDescriptorClass node::reflection(node::initReflection); 
void node::initReflection(reflect::typeDescriptorClass* typeDesc) {
		using T = node;
		typeDesc->name = "node";
		typeDesc->size = sizeof(T);
		typeDesc->members = {
			REFLECT_CLASS_MEMBER(key)
		};
}
#endif