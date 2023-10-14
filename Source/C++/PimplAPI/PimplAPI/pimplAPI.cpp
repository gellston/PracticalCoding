#include "pimplAPI.h"

#include <nlohmann/json.hpp>

namespace api {

	class impl_pimplAPI {
	public:
		nlohmann::json _json;

		impl_pimplAPI() {

		}
	};
}


api::pimplAPI::pimplAPI() : _instance(new impl_pimplAPI()) {


}

api::pimplAPI::~pimplAPI() {


}

int api::pimplAPI::get(std::string key) {
	try {
		return this->_instance->_json[key].get<int>();
	}
	catch (std::exception e) {
		throw e;
	}
}

void api::pimplAPI::set(std::string key, int value) {
	try {
		this->_instance->_json[key] = value;
	}
	catch (std::exception e) {
		throw e;
	}
}