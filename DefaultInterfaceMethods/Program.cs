using System;

namespace DefaultInterfaceMethods
{
	interface IProgram
	{
		static void Main(string[] args)
		{
			Sample3();
		}

		static void Sample1()
		{
			var human = new Human("Volodymyr");
			//human.SayHello(); - does not compile
		}

		static void Sample2()
		{
			IHuman human = new Human("Volodymyr");
			string hello = human.SayHello();
			Console.WriteLine(hello);
		}

		static void Sample3()
		{
			var human = new Human("Volodymyr");

			string hello = ((IHuman)human).SayHello();
			Console.WriteLine(hello);

			hello = ((IFriendlyHuman)human).SayHello();
			Console.WriteLine(hello);
		}

		static void Sample4()
		{
			//Have a look at ITalk.cs
		}
	}
}
