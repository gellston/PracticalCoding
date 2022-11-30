#pragma once

#ifndef DEF_CAR
#define DEF_CAR

#include <memory>

namespace hv {
	class impl_car;
	class car {
	private:
		std::unique_ptr<impl_car> _instance;

	public:
		car();
		~car();
		void ride();
	};
}

#endif