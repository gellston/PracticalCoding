
#include <opencv2/opencv.hpp>

#include "macro.h"
#include "cv4.h"

#include "hvexception.h"



//Cv4 Clas

namespace hv {
	class impl_cv4 {
	public:
		cv::Mat threshold_image;

	};
};


hv::cv4::cv4() : _instance(new impl_cv4()) {

}

hv::cv4::~cv4() {

}

void hv::cv4::test_set(std::shared_ptr<hv::image> source)  {
	
	try {
		cv::Mat matSource(cv::Size(source->width(), source->height()), CV_8UC1, source->pointer(), source->width());
		cv::Mat threshold;
		cv::threshold(matSource, threshold, 128, 255, cv::THRESH_BINARY);
		this->_instance->threshold_image = threshold;
	}
	catch (hv::hvexception error) {
		throw error;
	}


	
}

std::shared_ptr<hv::image> hv::cv4::test_get() {

	try {
		auto threshod_image = this->_instance->threshold_image;

		int width = threshod_image.cols;
		int height = threshod_image.rows;
		int channel = 1;


		std::shared_ptr<hv::image> resultImage(new hv::image(width, height, channel, hv::image_type::bit8));


		int size = width * height;

		std::memcpy(resultImage->pointer(), threshod_image.data, size);

	}
	catch (hv::hvexception error) {
		throw error;
	}

	


}


//Pure Function

void hv::cv4::sobel(std::shared_ptr<hv::image> source, std::shared_ptr<hv::image> target, int kernel_size) {

	try {
		cv::Mat matSource(cv::Size(source->width(), source->height()), CV_8UC1, source->pointer(), source->width());
		cv::Mat matTarget(cv::Size(target->width(), target->height()), CV_8UC1, target->pointer(), target->width());


		cv::Sobel(matSource, matTarget, CV_8UC1, 1, 1, kernel_size);
		

	}
	catch (hv::hvexception error) {
		throw error;
	}

}

std::shared_ptr<hv::image> hv::cv4::imread(std::string path, bool isColor) {

	try {


		cv::ImreadModes mode = cv::ImreadModes::IMREAD_GRAYSCALE;

		if(isColor = false)
			mode = cv::ImreadModes::IMREAD_GRAYSCALE;
		else
			mode = cv::ImreadModes::IMREAD_COLOR;

		auto image = cv::imread(path, mode);


		int width = image.cols;
		int height = image.rows;
		int channel = 1;

		int size = width * height;



		std::shared_ptr<hv::image> resultImage(new hv::image(width, height, channel, hv::image_type::bit8));

		std::memcpy(resultImage->pointer(), image.data, size);


		return resultImage;

	}
	catch (std::exception error) {
		HV_ERROR(image_error, "Invalid image info", 1);
		throw image_error;
	}

}