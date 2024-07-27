#include "typeDescriptor.h"



#pragma region Constructor

reflect::typeDescriptor::typeDescriptor(std::string name, std::size_t size) {
	this->name = name;
	this->size = size;
}

#pragma endregion

#pragma region Desturctor

reflect::typeDescriptor::~typeDescriptor() {

}
#pragma endregion


#pragma region Public Functions
std::string reflect::typeDescriptor::getFullName() const {

	return this->name;
}
#pragma endregion


