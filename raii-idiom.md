# RAII\(idiom\)

> 프로그램 함수의 Stack Frame 수명 주기가 끝나는 지점에 맞춰 사용자가 원하는 동작을 추가하는 방법



### Code

```cpp
#include <iostream>
#include <functional>



class raii_basic {
public:
    raii_basic() {

    }

    ~raii_basic() {
        std::cout << "end check" << std::endl;

    }
};


class raii_exit_call {
private:
    std::function<void()> __lambda;
public:
    raii_exit_call(std::function<void()> lambda) : __lambda(lambda) {

    }

    ~raii_exit_call() {
        __lambda();
    }
};



void main() {

    raii_basic end_check;


    double* memory = (double*)malloc(sizeof(double));

    raii_exit_call call([&] {
        if (memory)
            free(memory);
    });

}
```

### Result

```cpp
memory release check
end check
```

