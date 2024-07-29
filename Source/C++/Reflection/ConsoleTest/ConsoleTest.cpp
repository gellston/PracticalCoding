// ConsoleTest.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <iostream>
#include <vector>
#include <reflection.h>

#include "node.h"

int main()
{

    node test = {
        "test",
        512
    };


    auto descriptor = reflect::typeResolver<node>::get();
    auto name = descriptor->name;


    std::cout << "class name : " << name << std::endl;
    std::cout << "dump : " << name << std::endl;
    descriptor->dump(&test);



    
    
}

