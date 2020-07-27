using System;
using System.Collections.Generic;

namespace Deconstruction
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void Sample1()
        {
            Console.WriteLine("--------------Sample 1------------------");
            
            var city = new City("Chernivtsi", "Ukraine", 1408);
            
            //GetInfo returns ValueTuple<string, string, int>
            (string name, string country, int setupYear) cityInfo = city.Getinfo();

            Console.WriteLine(
                $"{cityInfo.name} is the city of {cityInfo.country}, which has been set up in {cityInfo.setupYear}");
            
            Console.WriteLine("----------End of Sample 1---------------");
        }

        private static void Sample2()
        {
            Console.WriteLine("--------------Sample 2------------------");
            
            var city = new City("Chernivtsi", "Ukraine", 1408);
            
            //Tuple can be deconstructed without types specification
            //Values in Tupe can be skipped
            var (cityName, _, citySetupYear) = city.Getinfo();

            Console.WriteLine($"{cityName} is the city, which has been set up in {citySetupYear}");
            
            Console.WriteLine("----------End of Sample 2---------------");
        }

        private static void Sample3()
        {
            Console.WriteLine("--------------Sample 3------------------");
            
            var city = new City("Chernivtsi", "Ukraine", 1408);
            
            //City implements Deconstruct method
            var (cityName, cityCountry, _) = city;

            Console.WriteLine($"{cityName} is the city of {cityCountry}");
            
            Console.WriteLine("----------End of Sample 3---------------");
        }

        private static void Sample4()
        {
            Console.WriteLine("--------------Sample 4------------------");
            
            var englishDutchDictionary = new Dictionary<string, string>
            {
                {"Hello", "Hoi"},
                {"How are you?", "Hoe gaat het?"}
            };

            //Deconstruction of KeyValuePair<string, string>
            foreach (var (english, dutch) in englishDutchDictionary)
            {
                Console.WriteLine($"English: {english}. Dutch: {dutch}");
            }
            
            Console.WriteLine("----------End of Sample 4---------------");
        }

        private static void Sample5()
        {
            Console.WriteLine("--------------Sample 5------------------");
            
            int a = 10;
            int b = 20;

            // int temp = a;
            // a = b;
            // b = temp;

            //Use deconstruction to swap variable values
            (a, b) = (b, a);

            Console.WriteLine($"{a} {b}");
            
            Console.WriteLine("----------End of Sample 5---------------");
        }
    }
}