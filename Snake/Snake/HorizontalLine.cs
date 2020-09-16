﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake 
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym, ConsoleColor.White);
                pList.Add(p);
            }
            /*Point p1 = new Point(3, 4, '*');
            Point p2 = new Point(4, 4, '*');
            Point p3 = new Point(5, 4, '*');
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);*/

        }
        
    }
}
