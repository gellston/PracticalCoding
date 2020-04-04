// PracticalCoding.cpp : �� ���Ͽ��� 'main' �Լ��� ���Ե˴ϴ�. �ű⼭ ���α׷� ������ ���۵ǰ� ����˴ϴ�.
//

#include <iostream>
#include <string>

#include <Windows.h>

#include <functional>

template <typename T>
class smart_pointer {
private:
	T * _pointer;

public:

	smart_pointer(int _count) {
		_pointer = (T*)malloc(_count * sizeof(T));
	}

	T* get() {
		return _pointer;
	}


	~smart_pointer() { // destructor !!!! 
		free(_pointer);
	}
};




class time_checker {

private:
	LARGE_INTEGER start, end, f;

	std::string __function;
	std::string __file;
	int __line;

public:
	time_checker(std::string _function, std::string _file, int _line) {

		this->__function = _function;
		this->__file = _file;
		this->__line = _line;

		// ���ػ� Ÿ�̸��� ���ļ��� ��´�.
		QueryPerformanceFrequency(&f);
		// ���� ������ CPU Ŭ������ ��´�.
		QueryPerformanceCounter(&start);
	}

	~time_checker() {
		// �� ������ Ŭ������ ��´�.
		QueryPerformanceCounter(&end);
		// �� ������ CPU Ŭ�������� ���� ������ Ŭ������ �� �� ���ļ��� 1000���� ���� ���� ������.
		// 1�� ������ ���ļ��� 1000 ���� �������� ������ 1�и��� ���� �߻��ϴ� �������� ���� ���̴�.
		__int64 ms_interval = (end.QuadPart - start.QuadPart) / (f.QuadPart / 1000);

		std::cout << "measured time = " << ms_interval << ":" << this->__file << ":" << this->__function << ":" << this->__line << std::endl;
	}
};




int function1(int index) {
	smart_pointer<double>  instance(500); // static declaration �̿�!! 

	double* ptr = instance.get();

	if (index == 0) {
		return 0;
	}

	if (index == 1) {
		return 1;
	}

	if (index == 2) {
		return 2;
	}

	if (index == 3) {
		return 3;
	}
	if (index == 4) {
		return 4;
	}

	if (index == 5) {
		return 5;
	}
}


void depth3() {
	time_checker checker(__FUNCTION__, __FILE__, __LINE__);
	Sleep(5000);
}



void depth2() {
	time_checker checker(__FUNCTION__, __FILE__, __LINE__);
	Sleep(1000);
	depth3();
}


void depth1() {
	time_checker checker(__FUNCTION__, __FILE__, __LINE__);
	depth2();
	Sleep(500);

}



class stack_caller {
private:
	std::function<void(void)> __instance;

public :

	stack_caller(std::function<void(void)> _instance) {
		this->__instance = _instance;
	}

	~stack_caller() {
		this->__instance();
	}
};



void lambdaRAIITest() {
	unsigned char* image = (unsigned char *)malloc(sizeof(unsigned char) * 2048 * 2049);
	unsigned char* image2 = (unsigned char*)malloc(sizeof(unsigned char) * 2048 * 2049);

	stack_caller instance([&]() {
		if (image != nullptr)
			free(image);
		if (image2 != nullptr)
			free(image2);

		std::cout << "lambda called!! " << std::endl;
	});



}




int main()
{
	//function1(0);
	//depth1();

	lambdaRAIITest();


}

