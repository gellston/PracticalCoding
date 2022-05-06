#pragma once
#ifndef HV_IGIGECAMERA
#define HV_IGIGECAMERA

#include <string>
#include "icamera.h"



namespace hv {


	class igigeCamera : public hv::icamera {

	public:
		virtual ~igigeCamera() {}
		virtual void open(std::string ip) = 0;
		virtual void close() = 0;
	};
}


#endif