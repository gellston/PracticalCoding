#include "hvImage.h"


using namespace hv;

#include <string>
#include <vector>
#include <iostream>



hvImage::hvImage() {
	this->_buffer;
}

hvImage::~hvImage() {


}

void hvImage::test(int _index) {
	
	std::vector<int> vector_test = { 1, 2};

	for (int& i : vector_test) {
		std::cout << i << std::endl;
	}
}