
#include "typeDescriptorStdString.h"


#include <iostream>

#pragma region Constructor
reflect::typeDescriptorStdString::typeDescriptorStdString() : typeDescriptor("std::string", sizeof(std::string)) {

}
#pragma endregion


#pragma region Destructor
reflect::typeDescriptorStdString::~typeDescriptorStdString() {

}
#pragma endregion

#pragma region Public Functions
void reflect::typeDescriptorStdString::dump(const void* obj, int indentLevel) {
	std::cout << "std::string{" << *(std::string*)obj << "}";

}
#pragma endregion

