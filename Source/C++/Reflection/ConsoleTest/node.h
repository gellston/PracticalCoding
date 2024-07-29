#pragma once

#ifndef NODE
#define NODE

#include <reflection.h>

class node {

	REFLECT()
#pragma region Private Property
private:
	std::string key;
	int value;
#pragma endregion

public:
#pragma region Constructor
	node(std::string key, int value);
#pragma endregion

#pragma region Destructor
	~node();
#pragma endregion

};

#endif