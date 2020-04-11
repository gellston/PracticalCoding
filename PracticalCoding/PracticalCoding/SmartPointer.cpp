
#include <memory>
#include <iostream>


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


void main() {

	std::shared_ptr<double> smart_pointer1(new double());

					// 형!!					 //형!!     [갯수]     //labmda  인풋 포인터*
	std::shared_ptr<unsigned char> array1(new unsigned char[1024], [](unsigned char* pointer) {
		delete[] pointer;  // delete구문 !!
	});
	

	std::shared_ptr<int> array2(new int[1024], [](int* pointer) {
		delete[] pointer;  // delete구문 !!
	});

	std::shared_ptr<testClass> array3(new testClass[1024], [](testClass* pointer) {
		delete[] pointer;  // delete구문 !!
	});


	auto unsignedArray = array1.get();
	unsignedArray[0] = 0;
	unsignedArray[1] = 1;
	unsignedArray[2] = 2;


	auto intArray = array2.get();
	intArray[0] = 0;
	intArray[1] = 1;
	intArray[2] = 2;
	intArray[3] = 3;


	auto classArray = array3.get();
	classArray[0].test();
	

} 