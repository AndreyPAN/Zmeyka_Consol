using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class FoodCreator
	{
		int heigt;
		int width;
		char symb;
		Random random = new Random();


		public FoodCreator( int w, int h, char s)
		{
			heigt = h; width = w; symb = s;
		}

		public Point CreateFood ()
		{
			int x =random.Next (2, width - 2);
			int y = random.Next(2, heigt - 2);

			Point food = new Point(x, y, symb);

			return food;

		}

	}
}
