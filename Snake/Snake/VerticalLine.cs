using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yUpper, int yLower, char sym)
        {
            pList = new List<Point>();
            for (int y = yUpper; y <= yLower; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
     }
}
