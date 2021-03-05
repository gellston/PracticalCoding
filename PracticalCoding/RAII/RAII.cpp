#include <iostream>
#include <functional>


#define TIME_MEASURE(x, y) \
clock_t ________startTime = 0;\
clock_t ________endTime = 0;\
________startTime = clock();\
const char * _____function_name = x;\
int ____line = y;\
raii aaaa([&] {\
		________endTime = clock();\
		float ________measuredTime = ((float)(________endTime - ________startTime) / CLOCKS_PER_SEC);\
		std::cout << "========================" << std::endl;\
		std::cout << "measured time = " << ________measuredTime << std::endl;\
		std::cout << "function = " << _____function_name << std::endl;\
		std::cout << "line = " << ____line << std::endl;\
});\


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

class raii {
private:
	std::function<void()> _instance;
public:
	raii(std::function<void()> lambda) {
		_instance = lambda;


	}

	~raii() {
		std::cout << "test" << std::endl;
		_instance();
	}

};


int test() {

	TIME_MEASURE(__FUNCTION__, __LINE__)
	int i = 0;

	unsigned char* test = (unsigned char *)malloc(sizeof(unsigned char) * 100);


	if (i = 1) {

		int i = 0;

	}


	return 0;
}
int bbbbb() {
	TIME_MEASURE(__FUNCTION__, __LINE__)
	return 1;
}



void main() {
	TIME_MEASURE(__FUNCTION__, __LINE__)

	int a = 1;

	if (a == 1) {
		TIME_MEASURE(__FUNCTION__, __LINE__)
		test();
	}

}