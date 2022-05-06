#pragma once
#ifndef HV_SENTECH
#define HV_SENTECH

#include <iostream>

#include "igigeCamera.h"




namespace hv {
	class sentechCamera : public hv::igigeCamera {
	public:

		sentechCamera() {

		}
		~sentechCamera() override {
			std::cout << "sentech camera destructed!!" << std::endl;
		}

		void open(std::string ip)override {

		}
		void close()override {

		}
		void grab()override {

		}
		void setexposure(int value)override {

		}

	};

}


#endif