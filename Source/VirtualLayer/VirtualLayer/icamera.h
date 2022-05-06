#pragma once
#ifndef HV_ICAMERA
#define HV_ICAMERA


namespace hv {

	class icamera {
	public:

		virtual ~icamera() {}
		virtual void grab() = 0;
		virtual void setexposure(int value) = 0;

	};

}

#endif

