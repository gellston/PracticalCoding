#include <iostream>
#include <memory>


class dummy {
public:
	dummy() {

	}

	~dummy() {
		std::cout << "destructor" << std::endl;
	}

	void test() {
		std::cout << "test" << std::endl;
	}
};


template <typename T> class custom_shared_ptr {
private:
	T * instance;
public:
	custom_shared_ptr() = delete;
	custom_shared_ptr(const custom_shared_ptr&) = delete;
	custom_shared_ptr(T* pointer) : instance(pointer) {

	}

	~custom_shared_ptr() {
		if (instance != nullptr)
			delete instance;
	}

	T* get() {
		return instance;
	}
};

std::shared_ptr<dummy> get_test() {
	std::shared_ptr<dummy> instance2(new dummy());

	return instance2;
}

void main() {


	
	std::shared_ptr<dummy> instance2(new dummy());
	std::shared_ptr<dummy> instance3(new dummy(), [](dummy* pointer) {
		delete pointer;
	});
	std::shared_ptr<unsigned char[]> instance4(new unsigned char[1000], [](unsigned char* pointer) {
		delete[] pointer;
	});
	

	instance2.get()->test();

	instance2->test();

	std::shared_ptr<dummy> instance4 = instance2;
}