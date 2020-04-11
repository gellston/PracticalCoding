#pragma once 

#include <memory>

namespace hv {
	class hvImage {
	private:
		std::shared_ptr<unsigned char> _buffer;
	public:

		hvImage();
		~hvImage();
		void test(int _index);
	};
};
