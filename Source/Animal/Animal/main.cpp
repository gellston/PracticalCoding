// Animal.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include "lion.h"

int main()
{

	pc::lion lion;

	pc::animal* animal1 = &lion;
	pc::animal* animal2 = new pc::lion();
	pc::catBase* cat1 = new pc::lion();



	delete animal2;
	delete cat1;
}
