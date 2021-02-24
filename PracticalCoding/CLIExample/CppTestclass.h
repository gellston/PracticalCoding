#pragma once


#include <string>
#include <iostream>

class cppTestClass {
private:
	std::string value;


public:

	~cppTestClass() {
		std::cout << "test" << std::endl;
	}
	void setString(std::string _value) {
		this->value = _value;
	}

	std::string getString() {
		return value;
	}
};