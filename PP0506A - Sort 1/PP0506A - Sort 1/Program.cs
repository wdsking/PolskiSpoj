using System;
using System.Collections.Generic;
using System.Linq;


namespace PP0506A___Sort_1
{
	class Point
	{
		public string name;
		public int x;
		public int y;
		public double magnitude { get { return Math.Sqrt(Math.Pow(x + y,2)); }}

	}

	class Program
	{
		static void Main(string[] args)
		{
			
				List<Point> points = new List<Point>();
				int testsCount = int.Parse(Console.ReadLine());
				if ( testsCount > 99) return;
				for (int i = 0; i < testsCount; i++)
				{
					int pointsCount = int.Parse(Console.ReadLine());
					if (pointsCount < 1 || pointsCount > 1000) return;
					points.Clear();
					for (int a = 0; a < pointsCount; a++)
					{
						Point p = new Point();
						string[] text = Console.ReadLine().Split();
						if (int.Parse(text[1]) < -1000 || int.Parse(text[2]) < -1000 || int.Parse(text[1]) > 1000 || int.Parse(text[2]) > 1000 || text[0].Length > 10) return;
						p.name = text[0];
						p.x = int.Parse(text[1]);
						p.y = int.Parse(text[2]);
						points.Add(p);

					}
					List<Point> SortedList = points.OrderBy(point => point.magnitude).ToList();
					for (int b = 0; b < SortedList.Count; b++)
					{
						Console.WriteLine($"{SortedList[b].name} {SortedList[b].x} {SortedList[b].y}");
					}
					Console.WriteLine();
				}
			
		}
	}
}
