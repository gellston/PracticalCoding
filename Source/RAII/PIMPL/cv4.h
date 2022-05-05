#pragma once


#include <memory>
#include <string>
#include "image.h"


namespace hv {

	class impl_cv4;

	class  HV_API cv4 {
	private:
		
		std::shared_ptr<impl_cv4> _instance;

	public:

		cv4();
		~cv4();

		static void sobel(std::shared_ptr<hv::image> source, std::shared_ptr<hv::image> target, int kernel_size);
		static std::shared_ptr<hv::image> imread(std::string, bool isColor);

		void test_set(std::shared_ptr<hv::image> source);
		std::shared_ptr<hv::image> test_get();
	};
};
