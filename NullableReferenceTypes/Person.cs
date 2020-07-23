namespace NullableReferenceTypes
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string? MiddleName { get; }

        public Person(string firstName, string lastName, string? middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        public string Greet()
        {
            return $"Hello, I am {FirstName} {MiddleName?[0]} {LastName}";
        }
    }
}