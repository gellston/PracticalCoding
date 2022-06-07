#pragma once
#ifndef CATBASE
#define CATBASE

#include <iostream>

#include "animal.h"

namespace pc {
	class catBase : public pc::animal{
	public:
		virtual ~catBase() override {
			std::cout << "cat base destructor" << std::endl;
		}


	protected:
		catBase() = default;
		catBase(catBase const&) = default;
		catBase(catBase&&) = default;

		catBase& operator=(catBase const&) = default;
		catBase& operator=(catBase&&) = default;


	};

}

#endif