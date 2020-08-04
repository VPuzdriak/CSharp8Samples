namespace PatternMatching
{
	public class Person
	{
		public string Name { get; }
		public PhoneNumber PhoneNumber { get; set; }

		public Person(string name)
		{
			Name = name;
		}
	}
}
