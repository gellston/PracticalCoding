#include "hvexception.h"


hv::hvexception::hvexception(const std::string message, int code) : std::runtime_error(message){

	this->_code = code;

}

int hv::hvexception::code() {

	return this->_code;
}
