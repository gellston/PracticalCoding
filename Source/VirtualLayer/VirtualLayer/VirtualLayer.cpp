// VirtualLayer.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <iostream>

#include "jaiCamera.h"
#include "sentechCamera.h"

int main()
{


	//std::shared_ptr<hv::jaiCamera> jaiCamera(new hv::jaiCamera());
	std::shared_ptr<hv::sentechCamera> sentechCamera(new hv::sentechCamera());



	std::shared_ptr<hv::igigeCamera> camera = sentechCamera;
	
	//System Part
	//System Part
	//System Part
	camera->open("tset");
	camera->close();
	camera->setexposure(512);
	camera->grab();
	




}


