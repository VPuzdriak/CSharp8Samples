namespace PatternMatching
{
	public class PhoneNumber
	{
		public string Code { get; }
		public string Number { get; }

		public PhoneNumber(string code, string number)
		{
			Code = code;
			Number = number;
		}
	}
}
