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
			int level = 1;
			int sleep = 150;

			Console.SetBufferSize (80, 25);

			Walls walls = new Walls(80, 25);

			walls.Draw();


			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.Right);
			snake.Draw();

			FoodCreator foodObj = new FoodCreator(79, 24, '$');

			Point food = foodObj.CreateFood();
			food.Draw();
			Console.Beep(250, 300);




			while (true)
			{
				Console.Title = "Уровень:" + level+"  Длина змейки: " + snake.pList.Count + "!!";

				if (walls.IsHit(snake) || snake.IsHitSnake(snake))
				{
					Console.Beep(350, 1000);
					Console.Clear();
					Console.SetCursorPosition(10, 10);
					Console.Write(" Вы проиграли \n Уровень {0} \n Длина змейки {1}", level, snake.pList.Count);

					Thread.Sleep(3000);


					break;
				}


				if (snake.Eat(food))
				{
					food = foodObj.CreateFood();
					food.Draw();
					Console.Beep(250, 50);

					if (snake.pList.Count>=50)
					{
						level++;
						if (level >= 4)
						{
							Console.Beep(550, 1000);
							Console.Clear();
							Console.SetCursorPosition(10, 10);
							Console.Write(" Поздравляем Вы выиграли !!!!!!!!!");

							Thread.Sleep(3000);


							break;

						}
						else
						{
							snake.NewLevel();
							sleep -= 40;
						}
					}

				}
				else
					snake.Move();

				Thread.Sleep(sleep);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.DirectSnake(key);
				}


			}

			Console.ReadKey();
		}

	}
}
