﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snake:Figure
	{
		public Snake(Point tail, int length, Direction direct)
		{
			pList = new List<Point>();
			for (int i = 0; i < length; i++)
			{
				Point p = new Point(tail);
				p.move(i, direct);
				pList.Add(p);
			}
		}
	}
}