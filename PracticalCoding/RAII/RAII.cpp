#include <iostream>
#include <functional>



class raii_basic {
public:
	raii_basic() {

	}

	~raii_basic() {
		std::cout << "end check" << std::endl;

	}
};


class raii_exit_call {
private:
	std::function<void()> __lambda;
public:
	raii_exit_call(std::function<void()> lambda) : __lambda(lambda) {

	}

	~raii_exit_call() {
		__lambda();
	}
};



void main() {

	raii_basic end_check;


	double* memory = (double*)malloc(sizeof(double));

	raii_exit_call call([&] {
		std::cout << "memory release check" << std::endl;
		if (memory)
			free(memory);
	});

}