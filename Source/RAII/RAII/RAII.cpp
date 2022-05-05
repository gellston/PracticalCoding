// RAII.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <iostream>
#include <functional>


class raii {
private:
	std::function<void()> _lambda;
public:

	raii(std::function<void()> lambda) {
		this->_lambda = lambda;
	}

	~raii() {
		this->_lambda();
	}

};



int main(){

	raii test([&] {
		std::cout << "check" << std::endl;
	});

}
