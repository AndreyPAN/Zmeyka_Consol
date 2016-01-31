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
		char symb;

		public Point(int x, int y, char symb)
		{
			this.x = x;
			this.y = y;
			this.symb = symb;

		}

		public void Draw()

		{
			Console.SetCursorPosition(x, y);
			Console.Write(symb);

		}
	}
}
