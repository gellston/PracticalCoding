
#include <iostream>


#include <vector>
#include <queue>
#include <array>
#include <stack>
//Sequential Continer


#include <map>
#include <unordered_map>


#include <string>


int main()
{
    //Template T C++ -> compile 
    //Generic T C# -> interpreter
    //Java Generic T JAVA -> 
    std::vector<double> test;
    test.resize(1024 * 1024);
    


    std::queue<double> test2;
    test2.push(5.0);
    auto value = test2.front();
    


    std::stack<double> test4;
    test4.push(5.0);
    auto testValue = test4.top();
    test4.pop();



    




    std::map<std::string, int> test7;
    test7["kevin"] = 20;
    test7["kevin1"] = 20;
    test7["kevin2"] = 20;
    test7["kevin3"] = 20;

    auto kevinAge = test7["kevin"];



}
