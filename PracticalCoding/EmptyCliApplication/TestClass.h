#pragma once

#include <iostream>
#include <vector>

class test_class {

public:

	test_class() {


	}

	void set_string(std::string _input) {
		std::cout << _input << std::endl;
	}

	std::vector<std::string> get_data() {
		std::vector<std::string> data;
		data.push_back("test");
		data.push_back("test");
		data.push_back("test");
		data.push_back("test");

		return data;
	}

	~test_class() {
		std::cout << "test" << std::endl;
	}
};



#include <msclr/marshal_cppstd.h>

using namespace System;
using namespace System::Collections;
using namespace System::Collections::Generic;

namespace HV {

	public ref class TestClass
	{
	private:
		test_class* _instance;

	public:

		TestClass() : _instance(new test_class()) {

		}

		~TestClass() {
			if (_instance != nullptr)
				delete _instance;

		}

		!TestClass() {
			if (_instance != nullptr)
				delete _instance;
		}

		void SetString(System::String^ _value) {
			auto native_string = msclr::interop::marshal_as<std::string>(_value);
			this->_instance->set_string(native_string);
		}

		System::Collections::Generic::List<System::String^>^ GetData() {
			auto native_vector = this->_instance->get_data();
			List<System::String^>^ managed_object = gcnew List<System::String^>();
			for (auto element : native_vector) {
				managed_object->Add(gcnew String(element.c_str()));
			}
			
			return managed_object;
		}

		

	};
};
