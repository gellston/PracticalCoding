#pragma once
#ifndef ANIMAL
#define ANIMAL


namespace pc {
	class animal {
	public:
		virtual ~animal() {
			std::cout << "animal destructor" << std::endl;
		}

	protected:
		animal() = default;
		animal(animal const&) = default;
		animal(animal&&) = default;

		animal& operator=(animal const&) = default;
		animal& operator=(animal&&) = default;


	};
}


#endif