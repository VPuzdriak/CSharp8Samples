using System;

namespace NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void Sample1()
        {
            var person = new Person("Volodymyr", "Puzdriak", null);
            Console.WriteLine(person.Greet());
        }

        private static void Sample2()
        {
            var person = new Person("Volodymyr", "Puzdriak", "Petrovych");
            string middleName = person.MiddleName!;
        }

        private static void Sample3()
        {
            var person = new Person("Volodymyr", null!, "Petrovych");
        }

        private static void Sample4()
        {
            var person = new Person("Volodymyr", "Puzdriak", "Petrovych");
            
            string? firstName = person.FirstName;
            int len = firstName.Length;
        }

        private static void Sample5()
        {
            var person = new Person("Volodymyr", "Puzdriak", "Petrovych");
            char? m = person.MiddleName!?[0];
        }
    }
}