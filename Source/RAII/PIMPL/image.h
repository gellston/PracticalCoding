#pragma once

#include <memory>
#include "image_type.h"
#include "macro.h"


namespace hv {

	class impl_image;
	class HV_API image {

	private:
		
		std::shared_ptr<impl_image> _instance;

	public:
		image() = delete;
		image(int width, int height, int channel, hv::image_type type);
		~image();

		int width();
		int height();
		int channel();
		hv::image_type type();

		unsigned char* pointer();


	};
};