#pragma once



using namespace System;

namespace CliAlgorithm {
	public ref class Algorithm
	{

	private:

	public:

		
		Algorithm() {

		}

		~Algorithm() {

		}

		!Algorithm() {

		}

		void Threshold(IntPtr bufferPointer, int Width, int Height, int threshold) {


			// C++ Code
			unsigned char* pointer = (unsigned char *)bufferPointer.ToPointer();


			// Stride 
			int strideSize = Width;

			for (int width = 0; width < Width; width++) {
				for (int height = 0; height < Height; height++) {
					unsigned char pixel = pointer[strideSize * height + width];

					if (pixel > threshold)
						pointer[strideSize * height + width] = 255;
					else 
						pointer[strideSize * height + width] = 0;
				}
			}
		}


	};
}
