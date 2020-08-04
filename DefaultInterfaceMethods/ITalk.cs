namespace DefaultInterfaceMethods
{
	public interface ITalker
	{
		string Greet();
	}

	public interface IBritishTalker : ITalker
	{
		string ITalker.Greet() => "Good day!";
	}

	public interface IAmericanTalker : ITalker
	{
		string ITalker.Greet() => "Howdy!";
	}

	// Diamond Inheritance - code does not compile
	//public class EnglishTalker : IBritishTalker, IAmericanTalker
	//{

	//}
}