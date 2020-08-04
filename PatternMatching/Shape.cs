namespace PatternMatching
{
	public abstract class Shape
	{

	}

	public class Rectangle : Shape
	{
		public int Width { get; }
		public int Height { get; }

		public Rectangle(int width, int height)
		{
			Width = width;
			Height = height;
		}

		public void Deconstruct(out int width, out int height)
		{
			width = Width;
			height = Height;
		}
	}

	public class Circle : Shape
	{
		public int X { get; }
		public int Y { get; }
		public int Radius { get; }

		public Circle(int x, int y, int radius)
		{
			X = x;
			Y = y;
			Radius = radius;
		}

		public void Deconstruct(out int x, out int y, out int radius)
		{
			x = X;
			y = Y;
			radius = Radius;
		}
	}
}