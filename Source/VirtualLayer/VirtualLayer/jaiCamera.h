#pragma once
#ifndef HV_JAICAMERA
#define HV_JAICAMERA

#include <iostream>


#include "igigeCamera.h"




namespace hv {
	class jaiCamera : public hv::igigeCamera {
	public:

		jaiCamera() {

		}
		~jaiCamera() override {
			std::cout << "jai camera destructed!!" << std::endl;
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