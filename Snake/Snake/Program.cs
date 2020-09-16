using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static Walls walls;
        static Snake snake;
        static Point food;
        static FoodCreator foodCreator;

        static void Main(string[] args)
        {
            //В начале было Слово, и Слово это -- Бох

            //И вот создал Бох Вселенную, Эа Сущую
            Console.CursorVisible = false;
            //int h = Console.BufferHeight;
            // w = Console.BufferWidth;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //Потом создал он великие Стены
            walls = new Walls(80, 25);
            walls.Draw();

            //Потом первую живую тварь
            Point p = new Point(4, 5, '*');
            snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            //Потом первую еду, ибо хотела тварь вкушать пищу
            foodCreator = new FoodCreator(80, 25, '$');
            food = foodCreator.CreateFood();
            food.Draw();

            StartTime();                    
        }

        static void StartTime() //Потом создал Бох время 
        {
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.SetCursorPosition(36, 12);
                    Console.WriteLine("СМЭРТЬ");
                    Console.ReadKey();
                    break;
                }

                if (snake.Eat(food))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;    //Цвет еды
                    food = foodCreator.CreateFood();
                    food.Draw();
                    Console.ForegroundColor = ConsoleColor.White;   //Цвет всего остального
                }
                else snake.Move(); //И вот приказал Он своей твари бесконечно бегать среди Великих стен, ибо хз че ещё делать
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handlekey(key.Key);
                }
            }
        }
    }
}
