using System;

namespace Task01
{
	public delegate void CoordChanged(Dot d);
	class Program
	{
		

		static void Main(string[] args)
		{
			double x, y;
			Console.WriteLine("Enter value for X: ");
			x = Double.Parse(Console.ReadLine());
			y = Double.Parse(Console.ReadLine());

			var D = new Dot(x, y);

			D.onCoordChanged += PrintInfo;

			D.DotFlow();
		}

		public static void PrintInfo(Dot A) {
			Console.WriteLine($"The coordinates of the dot are: {A.X}, {A.Y}");
		}
	}

	public class Dot
	{
		public double X {
			get; set;
		}
		public double Y
		{
			get; set;
		}

		public Dot(double a, double b) {
			X = a;
			Y = b;
		}
		public event CoordChanged onCoordChanged;

		public void DotFlow() {
			var rand = new Random();
			for (int i = 0; i < 10; i++)
			{
				var dot = new Dot(rand.NextDouble() * 20 - 10, rand.NextDouble() * 20 - 10);
				if (dot.X < 0 && dot.Y < 0) onCoordChanged?.Invoke(dot);
			}
			}
	}


}
