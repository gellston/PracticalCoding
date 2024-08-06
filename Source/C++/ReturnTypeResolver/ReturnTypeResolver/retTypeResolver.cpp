#include "retTypeResolver.h"


#pragma region Constructor
hv::retTypeResolver::retTypeResolver(double data) {
	this->data = data;
}

hv::retTypeResolver::retTypeResolver(int data) {
	this->data = (double)data;
}
#pragma endregion

#pragma region Type Casting Operator
hv::retTypeResolver::operator double() {
	return this->data;
}

hv::retTypeResolver::operator int() {
	return (int)this->data;
}

hv::retTypeResolver::operator std::string() {
	return std::to_string(this->data);
}
#pragma endregion


