using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Figure
	{
		public List<Point> pList;

		public void Draw()
		{
			foreach (Point item in pList)
			{
				item.Draw();
			}
		}


		internal bool IsHit (Figure figura)
		{
			foreach (var p in pList)
			{
				if (figura.Ishit(p))
					return true;
			}
			return false;
		}


		private bool Ishit (Point point)
		{
			foreach (Point p in pList)
			{
				if (p.IsHit(point))
					return true;
			}

			return false;
		}

	}
}
