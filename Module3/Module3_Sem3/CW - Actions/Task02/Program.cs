using System;

namespace Task02
{
	public delegate void SquareSizeChanged(double a);
	class Program
	{
		static void Main(string[] args)
		{
			double xUp, yUp, xDown, yDown;
			Console.WriteLine("Enter value for UpX: ");
			xUp = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter value for UpY: ");
			yUp = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter value for DownX: ");
			xDown = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter value for DownY: ");
			yDown = Double.Parse(Console.ReadLine());

			var S = new Square(xUp, yUp, xDown, yDown);

			S.OnSizeChanged += SquareConsoleInfo;

			int i = 0;
			do
			{
				Console.WriteLine("Enter value for DownX: ");
				S.DownX = Double.Parse(Console.ReadLine());
				Console.WriteLine("Enter value for DownY: ");
				S.DownY = Double.Parse(Console.ReadLine());
				i++;
			} while (i <= 3); ;

		}

		public static void SquareConsoleInfo(double a) {
			Console.WriteLine($"{a:f2}");
		}

	}

	class Square {

		private double upX, upY, downX, downY;
		public Square(double a, double b, double c, double d) {
			UpX = a;
			UpY = b;
			DownX = c;
			DownY = d;
		}

		public double UpX { get => upX; set { 
				OnSizeChanged?.Invoke(value);
				upX = value;
			} }
		public double UpY {
			get => upY; set
			{
				OnSizeChanged?.Invoke(value);
				upY = value;
			}
		}
		public double DownX {
			get => downX; set
			{
				OnSizeChanged?.Invoke(value);
				downX = value;
			}
		}
		public double DownY {
			get => downY; set
			{
				OnSizeChanged?.Invoke(value);
				downY = value;
			}
		}

		public event SquareSizeChanged OnSizeChanged;


	}
}
