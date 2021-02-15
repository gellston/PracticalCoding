
#include "pimpl_test_normal.h"


#include <string>


class pimpl {
private:
	std::string _delegate_string;

public:
	pimpl() {

	}

	~pimpl() {

	}

	void test() {
		
	}
};


RealClass::RealClass() : _instance(new pimpl()) {

}

RealClass::~RealClass() {
	delete _instance;
}


void RealClass::Test() {
	this->_instance->test();
}