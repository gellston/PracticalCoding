
// PIMPL_BASIC.cpp
#include "PIMPL_BASIC.h"

// Header�� ����
#include <string>


class pimpl {
private:
	// ��� ������ pimpl�� ����
	std::string _test;
public :
	pimpl(){

	
	}

	~pimpl() {

	}

	void test() {
		std::cout << "���� Ȯ��!!!!" << std::endl;
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