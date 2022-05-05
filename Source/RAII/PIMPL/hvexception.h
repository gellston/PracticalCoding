#pragma once


#include <stdexcept>

namespace hv {


    class hvexception : public std::runtime_error {

    private:
        int _code;

    public:

        hvexception(const std::string _message, int code);

        int code();

    };
}