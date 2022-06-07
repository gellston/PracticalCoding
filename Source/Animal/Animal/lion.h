#pragma once
#ifndef LION
#define LION

#include "catBase.h"

namespace pc {
	class lion final : public pc::catBase {
	public:
		virtual ~lion() override {
			std::cout << "lion base destructor" << std::endl;
		}

	public:
		lion() = default;
		lion(lion const&) = default;
		lion(lion&&) = default;

		lion& operator=(lion const&) = default;
		lion& operator=(lion&&) = default;


	};

}



#endif