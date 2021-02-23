// PIMPL_BASIC.h
#pragma once

#include <iostream>




// pimpl 전방선언 
class pimpl;


//pimpl을 소모할 클래스 정의
class PIMPL_BASIC {
private:
	pimpl * instance;
	

public :

	PIMPL_BASIC();
	~PIMPL_BASIC();

	void test();

};