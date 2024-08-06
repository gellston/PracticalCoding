
#include <iostream>
#include <vector>

#include "retTypeResolver.h"

int main()
{


	std::vector<hv::retTypeResolver> container{ 1, 0.2, 1 };

	std::cout << std::endl;
	std::cout << "double type" << std::endl;
	for (double resolver : container) {
		std::cout << resolver << std::endl;
	}

	std::cout << std::endl;
	std::cout << "string type" << std::endl;
	for (std::string resolver : container) {
		std::cout << resolver << std::endl;
	}

	std::cout << std::endl;
	std::cout << "int type" << std::endl;
	for (int resolver : container) {
		std::cout << resolver << std::endl;
	}

}

