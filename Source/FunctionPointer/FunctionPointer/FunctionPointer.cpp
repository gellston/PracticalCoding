// FunctionPointer.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <iostream>
#include <thread>
#include <chrono>
#include <functional>
#include <vector>
#include <algorithm>

namespace v1 {
    class system {
        std::function<int(int, int)> _function;

    public:

        system() {

        }
        void setOperator(std::function<int(int, int)> _operator) {
            this->_function = _operator;
        }

        void calculate() {

            std::cout << this->_function(5, 2) << std::endl;

        }

    };
}


int main()
{
    volatile int number = 5;


    std::vector<int> vector_array = { 1,2,3,4,5,6,7,8,9 };

    std::sort(vector_array.begin(), vector_array.end(), [&](int a, int b) {return a > b; });

    for (auto item : vector_array)
        std::cout << item << " ";

    
}
