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

			Console.SetBufferSize(80, 25);

			HorisontalLine horTop = new HorisontalLine(0, 78, 0, '+');
			HorisontalLine horDown = new HorisontalLine(0, 78, 24, '+');

			VerticalLine vertLeft = new VerticalLine(0, 24, 0, '+');
			VerticalLine vertRight = new VerticalLine(0, 24, 78, '+');
			horTop.Draw();
			horDown.Draw();
			vertLeft.Draw();
			vertRight.Draw();

			Point p = new Point(4,5,'*');
			Snake snake = new Snake(p, 4, Direction.Right);
			snake.Draw();
			for (int i = 0; i < 60; i++)
			{
				snake.Move();
				Thread.Sleep(100);
			}


			Console.ReadKey();
		}

	}
}
