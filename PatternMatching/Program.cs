using System;

namespace PatternMatching
{
	class Program
	{
		static void Main(string[] args)
		{
			Sample1();
			Sample2();
			Sample3();
			Sample4();
			Sample5();
			Sample6();
		}

		static void Sample1()
		{
			Console.WriteLine("--------------Sample 1------------------");

			Shape shape = new Rectangle(50, 50);

			switch (shape)
			{
				case Circle _:
					Console.WriteLine("It is a circle");
					break;

				case Rectangle sq when sq.Width == sq.Height:
					Console.WriteLine("It is a square");
					break;

				case Rectangle _:
					Console.WriteLine("It is a rectangle");
					break;

				default:
					Console.WriteLine("Shape is undefined");
					break;
			}

			Console.WriteLine("----------End of Sample 1---------------");
		}

		static void Sample2()
		{
			Console.WriteLine("--------------Sample 2------------------");

			object animal = new object();

			switch (animal)
			{
				case Pig _:
					Console.WriteLine("Fat meat");
					break;

				case Lamb _:
					Console.WriteLine("Soft meat");
					break;

				default:
					Console.WriteLine("Is it a meat?");
					break;
			}

			Console.WriteLine("----------End of Sample 2---------------");
		}

		static void Sample3()
		{
			Console.WriteLine("--------------Sample 3------------------");

			PhoneNumber phoneNumber = new PhoneNumber("31", "0846171548");

			string origin = phoneNumber switch
			{
				{ Number: "112" } => "SOS",
				{ Code: "31" } => "The Netherlands",
				{ } => "Origin was not determined",
				_ => null
			};

			Console.WriteLine($"Phone number origin: {origin}");

			Console.WriteLine("----------End of Sample 3---------------");
		}

		static void Sample4()
		{
			Console.WriteLine("--------------Sample 4------------------");

			var person = new Person("Robin")
			{
				PhoneNumber = new PhoneNumber("31", "0846171548")
			};

			var personOrigin = person switch
			{
				{ Name: "Volodymyr" } => "Ukraine",
				{ PhoneNumber: { Code: "31" } } => "The Netherlands",
				{ Name: var name } => $"No idea where {name} lives",
				_ => null
			};

			Console.WriteLine($"Person origin is {personOrigin}");

			Console.WriteLine("----------End of Sample 4---------------");
		}

		static void Sample5()
		{
			Console.WriteLine("--------------Sample 5------------------");

			var person = new Person("Robin")
			{
				PhoneNumber = new PhoneNumber("31", "0846171548")
			};

			var error = person switch
			{
				null => "Object is missing",
				{ PhoneNumber: null } => "Phone is missing",
				{ PhoneNumber: { Number: null } } => "Phone number is missing",
				{ PhoneNumber: { Number: "" } } => "Phone number is missing",
				{ PhoneNumber: { Code: var code } } when string.IsNullOrEmpty(code) || code == "0" => "Phone code is not valid",
				_ => null
			};

			Console.WriteLine($"Person validation error: {error ?? "Valid"}");

			Console.WriteLine("----------End of Sample 5---------------");
		}

		static void Sample6()
		{
			Console.WriteLine("--------------Sample 6------------------");

			Shape shape = new Rectangle(50, 50);

			var type = shape switch
			{
				Rectangle(int width, int height) when width == height => "Square",
				Rectangle(_, _) => "Rectangle",
				Circle(0, 0, _) => "Circle at origin",
				Circle(_, _, _) => "Circle",
				_ => "Undefined"
			};

			Console.WriteLine($"Shape is {type}");

			Console.WriteLine("----------End of Sample 6---------------");
		}
	}
}
