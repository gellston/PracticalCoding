# PIMPL\(idiom\)

> API 설계시 헤더의 의존과 멤버 변수를 숨기는 방법

### pimpl_basic.h

```cpp
// pimpl_basic.h
#pragma once

#include <iostream>


// pimpl 전방선언 
class pimpl;


//pimpl을 소모할 클래스 정의
class pimpl_basic {
private:
	pimpl* instance;
public :

	pimpl_basic();
	~pimpl_basic();

	void test();

};

```
### pimpl_basic.cpp
```cpp
// pimpl_basic.cpp
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

pimpl_basic::pimpl_basic() : instance(new pimpl()) {

}

pimpl_basic::~pimpl_basic() {
	if(!instance)
		delete instance;
}

void pimpl_basic::test() {
	this->instance->test();
}

```

### main.cpp

```cpp
// main.cpp
// 개발자가 설계한 헤더 이외에 다른 헤더 추가 불필요 
#include "pimpl_basic.h"

void main() {
	pimpl_basic basic;
	basic.test();

}

```

### Result

```cpp
동작 확인!!!!
```



