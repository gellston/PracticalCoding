
#include "typeDescriptorInt.h"

#include <iostream>


#pragma region Constructor

reflect::typeDescriptorInt::typeDescriptorInt() : typeDescriptor("int", sizeof(int)) {

}
#pragma endregion

#pragma region Destructor
reflect::typeDescriptorInt::~typeDescriptorInt() {


}
#pragma endregion


#pragma region Public Functions
void reflect::typeDescriptorInt::dump(const void* obj, int indentLevel) {
	std::cout << "int{" << *(int*)obj << "}";
}
#pragma endregion



