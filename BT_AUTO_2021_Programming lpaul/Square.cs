﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming_lpaul
{
    class Square
    {
        double side;
        
        public void SetSide(double side)
        {
            this.side = side;
        }

        public double GetArea()
        {
            return Math.Pow(side, 2);
        }

        public void PrintSquare()
        {
            Console.WriteLine("The square with side {0} has the area {1}", side, GetArea());
        }

    }
}
