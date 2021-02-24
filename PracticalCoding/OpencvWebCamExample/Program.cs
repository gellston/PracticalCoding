using OpenCvSharp;
using System;

namespace OpencvWebCamExample
{
    class Program
    {


        static VideoCapture capture;
        
        static void Main(string[] args)
        {

            capture = new VideoCapture(0);

            while (true)
            {
                var image = capture.RetrieveMat();

                // Gray로 바꾸는 코드
                Mat grayImage = new Mat(new Size(image.Width, image.Height), MatType.CV_8UC1);
                Cv2.CvtColor(image, grayImage, ColorConversionCodes.RGB2GRAY);


                // 결과 이미지 (비어있음)
                Mat outImage = new Mat(new Size(image.Width, image.Height), MatType.CV_8UC1);


                // 시작주소 
                // stide = step
                // height = 높이 

                BongKoo.ImageFilter.PrewittFilter(grayImage.Data, outImage.Data, image.Width, image.Height);
                // 결과이미지가 채워질거다.!!!


                Cv2.ImShow("Gray", grayImage);
                Cv2.ImShow("Original", image);
                Cv2.ImShow("Filter", outImage);

                if (Cv2.WaitKey(22) == 'q')
                    break;
            }
            
            
        }
    }
}
