
#include "node.h"


#pragma region REFLECTION
REFLECT_CLASS_BEGIN(node)
REFLECT_CLASS_MEMBER(key)
REFLECT_CLASS_MEMBER(value)
REFLECT_CLASS_END()
#pragma endregion


#pragma region Constructor
node::node(std::string key, int value) {
	this->key = key;
	this->value = value;
}

#pragma endregion

#pragma region Destructor
node::~node() {

}
#pragma endregion

