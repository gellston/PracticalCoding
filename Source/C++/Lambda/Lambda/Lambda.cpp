// Lambda.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <iostream>
#include <functional>
#include <algorithm>
#include <vector>
#include <array>

template<typename T> void templateFunc(T func) {
    func();
}


std::function<void(void)> getLambda() {
    return []() { std::cout << "Hello lambda!" << std::endl; };
}



class Person {
public:
    Person(std::string name) : name(name) {}
    void introduce() {
        [this]() { std::cout << "My name is " << name << std::endl; }();
    }
private:
    std::string name;
};



int main()
{
    []() { std::cout << "Hello lambda!" << std::endl; }();

    auto introduce = [](std::string name) {
        std::cout << "My name is " << name << std::endl;
    };

    introduce("Jinsoo Heo");


    auto foo = [] { return 3.14;};
    
    auto bar = []() -> float { return 3.14f; };

    float x = foo();

    float y = bar();

    auto foo2 = [] {std::cout << "Hello lambda!" << std::endl; };

    templateFunc(foo2);

    auto foo3 = getLambda();

    foo3();

    std::vector<std::function<void(void)>> funcs;

    funcs.push_back([]() { std::cout << "Hello" << std::endl; });
    funcs.push_back([]() {std::cout << "lambda!" << std::endl; });

    for (auto& func : funcs) {
        func();
    }

    std::array<int, 5> numbers = { 1, 2, 3, 4, 5 };
    int sum = 0;


    std::for_each(numbers.begin(), numbers.end(), [&sum](int& number) {
        sum += number;
    });


    std::string name = "Jinsoo Heo";

    [name]() {
        std::cout << "My name is " << name << std::endl;
    }();


    // sum을 복사로 캡처. mutable 지정자
    std::for_each(numbers.begin(), numbers.end(), [sum](int& number) mutable {
        // OK
        sum += number;
    });

    int x1 = 0;
    char y1 = 'J';
    double z1 = 3.14;
    std::string w1 = "Jinsoo Heo";

    // x, y는 참조로, z, w는 복사로 캡처.
    auto foo4 = [&x1, &y1, z1, w1]() {};


    Person* devkoriel = new Person("Jinsoo Heo");
    devkoriel->introduce(); // My name is Jinsoo Heo


    std::function<int(int)> factorial = [&factorial](int x) -> int {
        return x <= 1 ? 1 : x * factorial(x - 1);
    };

    std::cout << "factorial(5): " << factorial(5) << std::endl;


    return 1;
}
