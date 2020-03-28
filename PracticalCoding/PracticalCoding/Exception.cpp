// PracticalCoding.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <iostream>
#include <string>

#include <stdexcept>


#define errorMessage(name, error)  \
                    std::string (name) = error; \
                    (name) += __FILE__; \
                    (name) += ":"; \
                    (name) += __FUNCTION__; \
                    (name) += ":"; \
                    (name) += std::to_string(__LINE__); \


class logicalError : public std::runtime_error {
public:
    logicalError(std::string message) :std::runtime_error(message) {

    }
};



class formatError : public std::runtime_error {
public:
    formatError(std::string message) :std::runtime_error(message) {

    }
};
                                                // 조건
#define formatThrow(condition, message) if((condition)) throw formatError((message))
#define logicalThrow(condition, message) if((condition)) throw logicalError((message))

bool test1(int _value) {

    bool errorCheck = true;

    int value = 5;
    if (value == _value) {

        errorMessage(message1, "here is error1"); // 논리에러
        logicalError error(message1);
        throw error;
    }
    value = 7;
    if (value == _value) {
        errorMessage(message2, "here is error2"); // format에러
        formatError error(message2);

        throw error;
    }
        

    return errorCheck;
}

void test2() {

    try {
        test1(5);
    }
    catch (logicalError & error) {
        throw error;
    }
    catch (formatError & error) {
        throw error;
    }
    
}




int main()
{

    try {

        int value1 = 5;
        int value2 = 5;

        formatThrow((value1 > value2 && 10 == 10), "test");
        logicalThrow(true, "test!!");
    }
    catch (logicalError & error) {
        std::cout << error.what() << std::endl;
    }
    catch (formatError & error) {
        std::cout << error.what() << std::endl;
    }
    
}

