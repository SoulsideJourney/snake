﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            //Console.ForegroundColor = ConsoleColor.Cyan; //Цвет еды
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            //Point.draw();
            return new Point(x, y, sym, ConsoleColor.Cyan);
        }
    }
}
