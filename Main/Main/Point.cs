using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Point
    {
        // 포인트 표
        
        static public int SetPoint(double time)
        {
            if (time < 3) return 10;
            else if (time < 5) return 8;
            else if (time < 10) return 5;
            else if (time < 20) return 3;
            else return 1;
        }

        static public string Grade(int point)
        {
            if (point <= 0) return "청정수";
            else if (point <= 15) return "일반인";
            else if (point <= 50) return "꽤 아재";
            else if (point <= 100) return "아재";
            else if (point <= 150) return "아재 이상의 존재";
            else return "....";
        }
    }
}
