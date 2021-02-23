# PrcaticalCoding
실전 코딩으로 퇴근 시간을 줄이자!!

>고된 야근으로 고생하는 직장인들을 위한 실전 코딩에 도움이 되는 예제들을 수록한 github입니다. <br/>
샘플을 볼때 idiom 해결 방법과 OOP방법적인 해결 방법을 구분해서 보세요

###  Chapter 
##### C++
1. RAII. (idiom)
2. PIMPL. (idiom)
3. SMART POINTER

##### C#
1. ~~WPF - PANEL~~

<br/>

### RAII (idiom)

프로그램 함수의 Stack Frame 수명 주기가 끝나는 지점에 맞춰 사용자가 원하는 동작을 추가하는 방법

###### code
```c++
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
		if (memory)
			free(memory);
	});

}

```
```console
memory release check
end check
```
<br/>


### PIMPL (idiom)

 - API 설계시 헤더의 의존과 멤버 변수를 숨기는 방법

###### code
```c++
// PIMPL_BASIC.h
#pragma once

#include <iostream>


// pimpl 전방선언 
class pimpl;


//pimpl을 소모할 클래스 정의
class PIMPL_BASIC {
private:
	pimpl* instance;
public :

	PIMPL_BASIC();
	~PIMPL_BASIC();

	void test();

};


// PIMPL_BASIC.cpp
#include "PIMPL_BASIC.h"

// Header를 숨김
#include <string>


class pimpl {
private:
	// 멤버 변수를 pimpl에 선언
	std::string _test;
public :
	pimpl(){

	
	}

	~pimpl() {

	}

	void test() {
		this->_test = "Test!!!!!!!";
	}
};



PIMPL_BASIC::PIMPL_BASIC() : instance(new pimpl()) {

}

PIMPL_BASIC::~PIMPL_BASIC() {
	if(!instance)
		delete instance;
}

void PIMPL_BASIC::test() {
	this->instance->test();
}


// main.cpp
// 개발자가 설계한 헤더 이외에 다른 헤더 추가 불필요 
#include "PIMPL_BASIC.h"



void main() {
	PIMPL_BASIC basic;
	basic.test();

}

```
```console
동작 확인!!!!
```

<br/>



### SMART POINTER (idiom)

 - 자동으로 포인터의 수명을 관리하는 방법

###### code
```c++
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

template <typename T>
class custom_shared_ptr {
private:
	T* instance;
public:
	custom_shared_ptr() = delete;
	custom_shared_ptr(const custom_shared_ptr&) = delete;
	custom_shared_ptr(T* pointer) : instance(pointer) {

	}

	~custom_shared_ptr() {
		if (instance != nullptr)
			delete instance;
	}
};



void main() {

	custom_shared_ptr<dummy> instance1(new dummy());

	std::shared_ptr<dummy> instance2(new dummy());
	std::shared_ptr<dummy> instance3(new dummy(), [](dummy* pointer) {
		delete pointer;
	});
	std::shared_ptr<unsigned char[]> instance4(new unsigned char[1000], [](unsigned char* pointer) {
		delete[] pointer;
	});
	
	dummy* pointer = instance2.get();
	pointer->test();
}

```
```console
test
destructor
destructor
destructor
```

<br/>