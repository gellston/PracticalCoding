#pragma once

// Native Header
#include <string>
#include "CppTestclass.h"




//Managed Header
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

		TestClass() : _instance(new cppTestClass()){
	
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
