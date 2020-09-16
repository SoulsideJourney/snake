using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for(int i=0; i<lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
        
        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i<pList.Count-2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        public void Handlekey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                if (direction != Direction.RIGHT) direction = Direction.LEFT;
            }
               
            else if (key == ConsoleKey.RightArrow)
            {
                if (direction != Direction.LEFT) direction = Direction.RIGHT;
            }
                
            else if (key == ConsoleKey.DownArrow)
            {
                if (direction != Direction.UP) direction = Direction.DOWN;
            }
                
            else if (key == ConsoleKey.UpArrow)
            {
                if (direction != Direction.DOWN) direction = Direction.UP;
            }
                
        }
        internal bool Eat (Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                head.Draw();
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else return false;
        }

        public static Snake CreateNewSnake()
        {
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw(ConsoleColor.Green);
            return snake;
        }
    }
}
