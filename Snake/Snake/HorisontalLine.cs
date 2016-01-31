using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class HorisontalLine
	{
		List<Point> pHor;
		public HorisontalLine(int xLeft, int xRight, int y, char symb)
		{
			pHor = new List<Point>();
			for (int i = xLeft; i <= xRight; i++)
			{
				Point p = new Point(i, y, symb);
				pHor.Add(p);
			}

		}

		public void DrowHor ()
		{
			foreach (Point item in pHor)
			{
				item.Draw();
			}
		}

	}
}
