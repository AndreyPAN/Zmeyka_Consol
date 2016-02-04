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
		static void Main(string[] args)
		{


			Console.SetBufferSize (80, 25);

			Walls walls = new Walls(80, 25);

			walls.Draw();


			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.Right);
			snake.Draw();

			FoodCreator foodObj = new FoodCreator(79, 24, '$');

			Point food = foodObj.CreateFood();
			food.Draw();


			while (true)
			{

				if (walls.IsHit(snake) || snake.IsHitSnake(snake))
					break;

				if (snake.Eat(food))
				{
					food = foodObj.CreateFood();
					food.Draw();

				}
				else
					snake.Move();

				Thread.Sleep(200);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.DirectSnake(key);
				}


			}

			Console.Clear();
			Console.SetCursorPosition(10, 10);
			Console.Write("Длина змейки {0}", snake.pList.Count);
			Console.ReadKey();
		}

	}
}
