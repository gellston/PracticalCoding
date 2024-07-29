
#include "typeDescriptorDouble.h"


#include <iostream>


#pragma region Constructor
reflect::typeDescriptorDouble::typeDescriptorDouble() : typeDescriptor("double", sizeof(double)) {

}
#pragma endregion


#pragma region Destructor
reflect::typeDescriptorDouble::~typeDescriptorDouble() {

}
#pragma endregion

#pragma region Public Functions
void reflect::typeDescriptorDouble::dump(const void* obj, int indentLevel) {
	std::cout << "double{" << *(const double*)obj << "}";

}
#pragma endregion

