#pragma once

#ifndef PIMPL_API_HEADER
#define PIMPL_API_HEADER

#include "export.h"

#include <string>
#include <memory>

namespace api {

	class impl_pimplAPI;
	class pimplAPI {

	private:
		std::unique_ptr<impl_pimplAPI> _instance;

	public :
		PIMPL_API pimplAPI();
		PIMPL_API ~pimplAPI();


		PIMPL_API void set(std::string key, int value);
		PIMPL_API int get(std::string key);
	};


}


#endif