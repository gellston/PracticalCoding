// PIMPL_BASIC.h
#pragma once

#include <iostream>




// pimpl ���漱�� 
class pimpl;


//pimpl�� �Ҹ��� Ŭ���� ����
class PIMPL_BASIC {
private:
	pimpl * instance;
	

public :

	PIMPL_BASIC();
	~PIMPL_BASIC();

	void test();

};