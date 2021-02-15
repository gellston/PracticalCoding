
#include <memory>
#include <iostream>
#include <functional>


#include "pimpl_test_normal.h"

class testClass {

public:
	testClass() {

	}
	~testClass() {
	}


	void test() {
	}
};


std::shared_ptr<testClass> ArgumentTest()
{
	std::shared_ptr<testClass> smart_pointer1(new testClass());

	return smart_pointer1;
}  

class RAII {
private:
	std::function<void()> __lambda;
public :
	RAII(std::function<void()> lambda) : __lambda(lambda) {

	}

	~RAII() {
		__lambda();
	}
};





void main() {

	// LAII
	RAII instance([&](){
		std::cout << "test" << std::endl;
	});

	
	// PIMPL
	RealClass test;

} 