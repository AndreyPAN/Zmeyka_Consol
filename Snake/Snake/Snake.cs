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
	}
}
