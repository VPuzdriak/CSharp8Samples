using System;
using System.Collections.Generic;

namespace Deconstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample4();
        }

        private static void Sample1()
        {
            var city = new City("Chernivtsi", "Ukraine", 1408);
            (string name, string country, int setupYear) cityInfo = city.Getinfo();

            Console.WriteLine(
                $"{cityInfo.name} is the city of {cityInfo.country}, which has been set up in {cityInfo.setupYear}");
        }

        private static void Sample2()
        {
            var city = new City("Chernivtsi", "Ukraine", 1408);
            var (cityName, _, citySetupYear) = city.Getinfo();

            Console.WriteLine($"{cityName} is the city, which has been set up in {citySetupYear}");
        }

        private static void Sample3()
        {
            var city = new City("Chernivtsi", "Ukraine", 1408);
            var (cityName, cityCountry, _) = city;

            Console.WriteLine($"{cityName} is the city of {cityCountry}");
        }

        private static void Sample4()
        {
            var englishDutchDictionary = new Dictionary<string, string>
            {
                {"Hello", "Hoi"},
                {"How are you?", "Hoe gaat het?"}
            };

            foreach (var (english, dutch) in englishDutchDictionary)
            {
                Console.WriteLine($"English: {english}. Dutch: {dutch}");
            }
        }

        private static void Sample5()
        {
            int a = 10;
            int b = 20;

            // int temp = a;
            // a = b;
            // b = temp;

            (a, b) = (b, a);

            Console.WriteLine($"{a} {b}");
        }
    }
}