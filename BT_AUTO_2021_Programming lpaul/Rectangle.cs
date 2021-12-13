using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming_lpaul
{
    class Rectangle
    {
        double lenght;
        double width;

        public void SetSize(double lenght, double width)
        {
            this.lenght = lenght;
            this.width = width;
        }

        public double GetArea()
        {
            retunr lenght *width;
        }

        public void PrintRectangle()
        {
            Console.WriteLine("The rectangle with lenght {0} and width {1} has area {2}")
        }
    }
}
