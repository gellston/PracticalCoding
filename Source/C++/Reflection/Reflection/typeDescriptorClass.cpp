#include "typeDescriptorClass.h"


#pragma region Constructor
reflect::typeDescriptorClass::typeDescriptorClass(void (*init)(typeDescriptorClass*)) : typeDescriptor("", 0 ) {
	init(this);
}

reflect::typeDescriptorClass::typeDescriptorClass(std::string name, std::size_t size, const std::initializer_list<member>& init) : typeDescriptor(nullptr, 0) {
	this->members = init;
}
#pragma endregion


#pragma region Destructor
reflect::typeDescriptorClass::~typeDescriptorClass() {

}
#pragma endregion


#pragma region Public Property
void reflect::typeDescriptorClass::dump(const void* obj, int indentLevel){

}

#pragma endregion


