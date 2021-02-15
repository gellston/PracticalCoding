#pragma once






class pimpl;


class RealClass {
private:
	pimpl* _instance;

	
public :
	RealClass();
	~RealClass();
	void Test();

};