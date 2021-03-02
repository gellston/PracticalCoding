# SMART POINTER \(idiom\)

> 자동으로 동적 메모리의 수명을 관리하는 방법

### Code

```cpp
#include <iostream>
#include <memory>


class dummy {
public:
    dummy() {

    }

    ~dummy() {
        std::cout << "destructor" << std::endl;
    }

    void test() {
        std::cout << "test" << std::endl;
    }
};

template <typename T>
class custom_shared_ptr {
private:
    T* instance;
public:
    custom_shared_ptr() = delete;
    custom_shared_ptr(const custom_shared_ptr&) = delete;
    custom_shared_ptr(T* pointer) : instance(pointer) {

    }

    ~custom_shared_ptr() {
        if (instance != nullptr)
            delete instance;
    }
};



void main() {

    custom_shared_ptr<dummy> instance1(new dummy());

    std::shared_ptr<dummy> instance2(new dummy());
    std::shared_ptr<dummy> instance3(new dummy(), [](dummy* pointer) {
        delete pointer;
    });
    std::shared_ptr<unsigned char[]> instance4(new unsigned char[1000], [](unsigned char* pointer) {
        delete[] pointer;
    });

    dummy* pointer = instance2.get();
    pointer->test();
}
```

### Result

```cpp
test
destructor
destructor
destructor
```

