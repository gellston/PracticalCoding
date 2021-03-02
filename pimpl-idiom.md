---
description: API 설계시 헤더의 의존과 멤버 변수를 숨기는 방법
---

# PIMPL\(idiom\)

### Code

```cpp
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

### Result

```cpp
동작 확인!!!!
```



