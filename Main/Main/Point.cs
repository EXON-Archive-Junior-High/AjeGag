using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Point
    {
        
        static public int SetPoint(double time)
        {
            if (time < 3)
            {
                return 10;
            }
            else if (time < 5)
            {
                return 8;
            }
            else if (time < 10)
            {
                return 5;
            }
            else if (time < 20)
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }
    }
}
