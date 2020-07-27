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
            Console.WriteLine("--------------Sample 1------------------");

            //Passing null as middlename - no warnings. MiddleName can be null
            var person = new Person("Volodymyr", "Puzdriak", null);
            Console.WriteLine(person.Greet());
            
            Console.WriteLine("----------End of Sample 1---------------");
        }

        private static void Sample2()
        {
            Console.WriteLine("--------------Sample 2------------------");

            var person = new Person("Volodymyr", "Puzdriak", "Petrovych");
            
            //Using bang operator to prevent warnings, because MiddleName is nullable
            string middleName = person.MiddleName!;
            
            Console.WriteLine("----------End of Sample 2---------------");
        }

        private static void Sample3()
        {
            Console.WriteLine("--------------Sample 3------------------");
            
            //Passing null and claiming that it is not null - nonsense
            var person = new Person("Volodymyr", null!, "Petrovych");
            
            Console.WriteLine("----------End of Sample 3---------------");
        }

        private static void Sample4()
        {
            Console.WriteLine("--------------Sample 4------------------");
            
            var person = new Person("Volodymyr", "Puzdriak", "Petrovych");

            //Using string?. Because FirstName is not nullable - compiler won't give a warning
            string? firstName = person.FirstName;
            int len = firstName.Length;
            
            Console.WriteLine("----------End of Sample 4---------------");
        }

        private static void Sample5()
        {
            Console.WriteLine("--------------Sample 5------------------");
            
            var person = new Person("Volodymyr", "Puzdriak", "Petrovych");
            
            //Claiming that MiddleName is not null and can be null in the same time - nonsense
            char? m = person.MiddleName!?[0];
            
            Console.WriteLine("----------End of Sample 5---------------");
        }
    }
}