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
		public Snake(Point tail, int length, Direction direct)
		{
			this.direction = direct;
			pList = new List<Point>();
			for (int i = 0; i < length; i++)
			{
				Point p = new Point(tail);
				p.move(i, direct);
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

			head.Draw();

		}

		internal Point GetNextPoint()
		{
			Point head = pList.Last();
			Point next = new Point(head);

			next.move(1, direction);

			return next;
		}


		public void DirectSnake (ConsoleKeyInfo key)
		{
			if (key.Key == ConsoleKey.LeftArrow)
			{
				direction = Direction.Left;
			}
			else if (key.Key == ConsoleKey.RightArrow)
			{
				direction = Direction.Right;
			}
			else if (key.Key == ConsoleKey.UpArrow)
			{
				direction = Direction.Up;
			}
			else if (key.Key == ConsoleKey.DownArrow)
			{
				direction = Direction.Down;
			}


		}

		internal bool Eat (Point food)
		{
			Point head = GetNextPoint();
			if (head.IsHit(food))
			{
				food.symb = head.symb;
				food.Draw();
				pList.Add(food);
				return true;
			}
			else
				return false;

		}

		internal bool IsHitSnake(Snake snake)
		{
			Point nextHead = GetNextPoint();
			foreach (Point p in pList)
			{
				if (nextHead.IsHit(p))
					return true;
			}
			return false;

		}


	}
}
