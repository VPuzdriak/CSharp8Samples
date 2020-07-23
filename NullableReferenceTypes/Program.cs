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

            var person = new Person("Volodymyr", "Puzdriak", null);
            Console.WriteLine(person.Greet());
            
            Console.WriteLine("----------End of Sample 1---------------");
        }

        private static void Sample2()
        {
            Console.WriteLine("--------------Sample 2------------------");

            var person = new Person("Volodymyr", "Puzdriak", "Petrovych");
            string middleName = person.MiddleName!;
            
            Console.WriteLine("----------End of Sample 2---------------");
        }

        private static void Sample3()
        {
            Console.WriteLine("--------------Sample 3------------------");
            
            var person = new Person("Volodymyr", null!, "Petrovych");
            
            Console.WriteLine("----------End of Sample 3---------------");
        }

        private static void Sample4()
        {
            Console.WriteLine("--------------Sample 4------------------");
            
            var person = new Person("Volodymyr", "Puzdriak", "Petrovych");

            string? firstName = person.FirstName;
            int len = firstName.Length;
            
            Console.WriteLine("----------End of Sample 4---------------");
        }

        private static void Sample5()
        {
            Console.WriteLine("--------------Sample 5------------------");
            
            var person = new Person("Volodymyr", "Puzdriak", "Petrovych");
            char? m = person.MiddleName!?[0];
            
            Console.WriteLine("----------End of Sample 5---------------");
        }
    }
}