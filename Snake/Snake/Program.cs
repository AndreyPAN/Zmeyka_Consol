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
			Point p1 = new Point(2, 3, '*');
			Point p2 = new Point(5, 6, '#');

			p1.Draw();
			p2.Draw();

			List<char> charList = new List<char>();
			charList.Add('*');
			charList.Add('#');
			charList.Add('+');
			charList.Add('-');
			charList.Add('&');

			foreach (var item in charList)
			{
				Console.WriteLine("\n"+item);
			}

			List<Point> pointCol = new List<Point>();
			pointCol.Add(p1);
			pointCol.Add(p2);
			pointCol.Add(new Point(6, 7, '%'));
			
			foreach (var i in pointCol)
			{
				i.Draw();
			} 







			Console.ReadKey();
		}

	}
}
