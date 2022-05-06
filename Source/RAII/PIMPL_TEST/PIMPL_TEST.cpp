// PIMPL_TEST.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <iostream>

#include <opencv2/opencv.hpp>
#include <cv4.h>


int main()
{
    
    auto image = hv::cv4::imread("C://Users//gellston//Desktop//KakaoTalk_20220314_124031083.jpeg", false);
    std::shared_ptr<hv::image> sobel(new hv::image(image->width(), image->height(), 1, hv::image_type::bit8));


    hv::cv4::sobel(image, sobel, 3);

    

    hv::cv4 cv;


    cv.test_set(image);

    auto thresholdImage = cv.test_get();



    cv::Mat cvImage(cv::Size(image->width(), image->height()), CV_8UC1, image->pointer(), image->width());
    cv::Mat cvSobel(cv::Size(sobel->width(), sobel->height()), CV_8UC1, sobel->pointer(), sobel->width());
    cv::Mat cvThreshold(cv::Size(thresholdImage->width(), thresholdImage->height()), CV_8UC1, thresholdImage->pointer(), thresholdImage->width());
   



    cv::namedWindow("test1", cv::WINDOW_FREERATIO);
    cv::resizeWindow("test1", cv::Size(512, 512));
    cv::imshow("test1", cvImage);

    cv::namedWindow("test2", cv::WINDOW_FREERATIO);
    cv::resizeWindow("test2", cv::Size(512, 512));
    cv::imshow("test2", cvSobel);


    cv::namedWindow("test3", cv::WINDOW_FREERATIO);
    cv::resizeWindow("test3", cv::Size(512, 512));
    cv::imshow("test3", cvThreshold);

    cv::waitKey();


}
