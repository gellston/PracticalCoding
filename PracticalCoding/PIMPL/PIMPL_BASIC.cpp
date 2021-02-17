
// PIMPL_BASIC.cpp
#include "PIMPL_BASIC.h"

// Header¸¦ ¼û±è
#include <string>


class pimpl {
private:
	// ¸â¹ö º¯¼ö¸¦ pimpl¿¡ ¼±¾ð
	std::string _test;
public :
	pimpl(){

	
	}

	~pimpl() {

	}

	void test() {
		std::cout << "µ¿ÀÛ È®ÀÎ!!!!" << std::endl;
		this->_test = "Test!!!!!!!";
	}
};



PIMPL_BASIC::PIMPL_BASIC() : instance(new pimpl()) {

}

PIMPL_BASIC::~PIMPL_BASIC() {
	if(!instance)
		delete instance;
}

void PIMPL_BASIC::test() {
	this->instance->test();
}