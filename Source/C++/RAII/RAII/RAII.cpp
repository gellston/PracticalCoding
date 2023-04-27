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

int main()
{
    {
        raii check([&] {
            std::cout << "raii call" << std::endl;
        });


        std::cout << "scope out" << std::endl;
    }
}
