namespace DefaultInterfaceMethods
{
	public interface IHuman
	{
		string Name { get; }

		string SayHello()
		{
			return $"Hello, I am {Name}";
		}
	}

	public interface IFriendlyHuman : IHuman
	{
		new string SayHello()
		{
			return $"Hey there, I am {Name}";
		}
	}

	public class Human : IHuman, IFriendlyHuman
	{
		public string Name { get; }

		public Human(string name)
		{
			Name = name;
		}
	}
}