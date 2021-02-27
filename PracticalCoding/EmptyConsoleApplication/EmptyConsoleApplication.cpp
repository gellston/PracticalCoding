// 테스트용 콘솔 프로그램
//

#include <iostream>
#include <memory>


class test {

public:

	test() {


	}

	void AAAA() {

	}

	~test() {
		std::cout << "test" << std::endl;
	}
};

std::shared_ptr<test> A() {
	std::shared_ptr<test> instance(new test());
	instance->AAAA();

	return instance;
}

int main()
{


	return 1;
}
