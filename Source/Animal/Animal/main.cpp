// Animal.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include "animal.h"


class camera {

private:



protected:
	camera() = default;

public:
	virtual ~camera() {
		std::cout << "interface destroy" << std::endl;
	}

	virtual void grab() = 0;
	virtual void exposure() = 0;
	virtual void test() = 0;


};





class crevisCamera final : public camera {
public:
	crevisCamera() {

	}
	virtual ~crevisCamera() override {
		std::cout << "crevis destory" << std::endl;
	}

	void exposure() {
		std::cout << "crevis test1" << std::endl;
		
	}

	void grab() {
		std::cout << "crevis test1" << std::endl;
	}

	void test() {

	}
};




class flirCamera final : public camera {
public:
	flirCamera() {

	}

	virtual ~flirCamera() override {
		std::cout << "crevis destory" << std::endl;
	}

	void exposure() {
		std::cout << "flir test1" << std::endl;
	}

	void grab() {
		std::cout << "flir test1" << std::endl;
	}

	void test() {
		//구현안되어있음! 
		throw std::exception("Its not implemented, its not supported");

	}

};






int checkHeight(camera *  camera) {



	return 0;
}

int main() //MAINMAINMAINMAINMAINMAINMAINMAINMAINMAINMAINMAINMAINMAINMAINMAIN
{

	camera* _camera = new flirCamera();

	//flirCameraLightConfiguration* config = (flirCameraLightConfiguration*)_camera;
	//config->setLight();

	flirCamera* flir = (flirCamera*)_camera;




	delete _camera;


	return 0;
}
