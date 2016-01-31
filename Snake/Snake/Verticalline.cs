using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class VerticalLine
	{
		List<Point> pVert;
				
		public VerticalLine(int yTop, int yDown, int x, char symb)
		{
			pVert = new List<Point>();
			for (int i = yTop; i <= yDown; i++)
			{
				Point p = new Point(x, i, symb);
				pVert.Add(p);
			}
		}

		public void DrawVert ()
		{
			foreach (Point item in pVert)
			{
				item.Draw();
			}
		}

	}
}
