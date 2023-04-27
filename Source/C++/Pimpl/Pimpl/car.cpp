#include "car.h"

#include <iostream>

namespace hv {
	class impl_car {
	public:

		double speed;

		impl_car() {
			speed = 50;
		}

	};
}

hv::car::car() : _instance(new hv::impl_car()) {

}

hv::car::~car() {

}

void hv::car::ride() {
	std::cout << "ride!! = " << this->_instance->speed << std::endl;
}