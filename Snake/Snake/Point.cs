using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Point
	{
		int x;
		int y;
		 public char symb;

		public Point(int x, int y, char symb)
		{
			this.x = x;
			this.y = y;
			this.symb = symb;

		}
		public Point(Point p)
		{
			this.x = p.x;
			this.y = p.y;
			this.symb = p.symb;
		}

		public void Draw()

		{
			Console.SetCursorPosition(x, y);
			Console.Write(symb);


		}

		public void move(int shift, Direction direct)
		{
			if (direct == Direction.Right)
			{
				x = x + shift;
			}
			else if (direct == Direction.Left)
			{
				x = x - shift;
			}
			else if (direct == Direction.Up)
			{
				y = y - shift;
			}
			else
			{
				y = y + shift;
			}


		}

		public void Clear ()
		{
			symb = ' ';
			Draw();
		}

		public bool IsHit (Point p)
		{
		return 	p.x == this.x && p.y == this.y;
		}

		public override string ToString()
		{
			return x+ ", "+y+ ", "+ symb;
		}
	}
}
