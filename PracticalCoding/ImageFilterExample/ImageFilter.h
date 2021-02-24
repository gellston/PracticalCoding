#pragma once


#include <iostream>


using namespace System;
using namespace System::Collections;
using namespace System::Collections::Generic;




namespace BongKoo {

	public ref class ImageFilter
	{
	private:

	

	public:


		ImageFilter() {

		}

		~ImageFilter() {

		}

		!ImageFilter() {

		}

		static void PrewittFilter(IntPtr InImagePointer, IntPtr OutImagePointer, int imageWidth, int imageHeight) {
			unsigned char * native_input_pointer = static_cast<unsigned char *> (InImagePointer.ToPointer());
			unsigned char* native_output_pointer = static_cast<unsigned char*> (OutImagePointer.ToPointer());


			for (int height = 1; height < imageHeight -1; height++) {
				for (int width = 1; width < imageWidth -1; width++) {
					
					unsigned char pixel1 = native_input_pointer[(height-1) * imageWidth + (width-1)]; //  좌측 상단
					unsigned char pixel2 = native_input_pointer[(height-1) * imageWidth + (width)]; // 중심 상단
					unsigned char pixel3 = native_input_pointer[(height-1) * imageWidth + (width+1)]; // 우측 상단
					unsigned char pixel4 = native_input_pointer[(height) * imageWidth + (width+1)]; // 우측 중앙
					unsigned char pixel5 = native_input_pointer[(height+1) * imageWidth + (width+1)]; 
					unsigned char pixel6 = native_input_pointer[(height+1) * imageWidth + (width)];
					unsigned char pixel7 = native_input_pointer[(height + 1)*imageWidth + (width-1)];
					unsigned char pixel8 = native_input_pointer[(height) * imageWidth + (width-1)];
					unsigned char pixel9 = native_input_pointer[(height) * imageWidth + (width)];
					double result = -1 * pixel1 + -1 * pixel7 + -1 * pixel8 + pixel3 + pixel5 + pixel4;
					result = result / 9;
					native_output_pointer[height * imageWidth + width] = (unsigned char)result;
				}
			}


		}
	};
};