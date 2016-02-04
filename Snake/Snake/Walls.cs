using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Walls
	{
		List<Figure> ListWalls;

		public Walls(int mapWidth, int mapHeigth)
		{
			ListWalls = new List<Figure>();
			HorisontalLine horTop = new HorisontalLine(0, mapWidth-2, 0, '+');
			HorisontalLine horDown = new HorisontalLine(0, mapWidth-2, mapHeigth-1, '+');

			VerticalLine vertLeft = new VerticalLine(0, mapHeigth-1, 0, '+');
			VerticalLine vertRight = new VerticalLine(0, mapHeigth-1, mapWidth-2, '+');

			ListWalls.Add(horTop);
			ListWalls.Add(horDown);
			ListWalls.Add(vertLeft);
			ListWalls.Add(vertRight);


		}


		public void Draw ()
		{
			Console.ForegroundColor = ConsoleColor.Red;

			foreach (Figure line in ListWalls)
			{
				line.Draw();
			}

			Console.ForegroundColor = ConsoleColor.White;
		}


		internal bool IsHit (Figure figura)
		{
			foreach (var wall in ListWalls)
			{
				if (wall.IsHit(figura))
					return true;
			}

			return false;

		}

	}
}
