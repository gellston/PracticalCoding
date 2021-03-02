# PrcaticalCoding

실전 코딩으로 퇴근 시간을 줄이자!!

> 고된 야근으로 고생하는 직장인들을 위한 실전 코딩에 도움이 되는 예제들을 수록한 github입니다.   
>  샘플을 볼때 idiom 해결 방법과 OOP방법적인 해결 방법을 구분해서 보세요

## Chapter

### C++

1. [RAII. \(idiom\)](raii-idiom.md)
2. [PIMPL. \(idiom\)](pimpl-idiom.md)
3. [SMART POINTER](smart-pointer-idiom.md)

### C\#

1. ~~WPF - PANEL~~
2. ~~CLI Example~~

## 

* 자동으로 포인터의 수명을 관리하는 방법

#### code

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

```text
test
destructor
destructor
destructor
```

## CLI Example \(WPF\)

* C++를 이용하여 C\# dll 만드는 예제.

#### code

```cpp
#pragma once

#include <string>
#include "CppTestclass.h"
#include "managed_shared_ptr.h"
#include <msclr/marshal_cppstd.h>

using namespace System;
using namespace System::Collections;
using namespace System::Collections::Generic;

namespace HV {

    public ref class TestClass
    {
    private:

        HV::V1::mananged_shared_ptr<cppTestClass> _instance;

    public:

        TestClass() : _instance(new cppTestClass()) {

        }

        ~TestClass() {

        }

        !TestClass() {

        }

        void SetString(System::String^ _value) {
            std::string native_string = msclr::interop::marshal_as<std::string>(_value);
            _instance->setString(native_string);
        }

        System::String^ GetString() {
            auto value = _instance->getString();
            return gcnew System::String(value.c_str());
        }
    };
};
```

```text
test
```

