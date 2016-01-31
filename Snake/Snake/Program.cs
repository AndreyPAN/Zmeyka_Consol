using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{

			HorisontalLine lineh = new HorisontalLine(5, 13, 8, '*');
			VerticalLine linev = new VerticalLine(0, 8, 5, '+');
			lineh.DrowHor();
			linev.DrawVert();


			Console.ReadKey();
		}

	}
}
