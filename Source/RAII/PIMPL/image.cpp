#include "image.h"
#include "hvexception.h"
#include "macro.h"

#include <vector>
#include <string>

namespace hv {
	class impl_image {
	public:
		int width;
		int height;
		int channel;
		hv::image_type type;

		std::vector<unsigned char> buffer;
	};
}


hv::image::image(int width, int height, int channel, hv::image_type type) : _instance(new impl_image()) {
	
	this->_instance->width = width;
	this->_instance->height = height;
	this->_instance->channel = channel;
	this->_instance->type = type;


	if (width <= 0 || height <= 0 || channel <= 0) {
		HV_ERROR(image_error, "Invalid image info", 1);
		throw image_error;
	}

	int size = width * height * channel;

	this->_instance->buffer.resize(size);


}


hv::image::~image() {

}

int hv::image::width() {
	return this->_instance->width;
}
int hv::image::height() {
	return this->_instance->height;
}
int hv::image::channel() {
	return this->_instance->channel;
}
hv::image_type hv::image::type() {
	return this->_instance->type;
}

unsigned char* hv::image::pointer() {
	return this->_instance->buffer.data();
}