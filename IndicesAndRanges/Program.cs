using System;
using System.Collections.Generic;

namespace IndicesAndRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample12();
        }

        private static void Sample1()
        {
            Console.WriteLine("--------------Sample 1------------------");
            
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var firstElIndex = new Index(0);
            Console.WriteLine(arr[firstElIndex]);
            
            Console.WriteLine("----------End of Sample 1---------------");
        }

        private static void Sample2()
        {
            Console.WriteLine("--------------Sample 2------------------");
            
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Index fourthElIndex = 3;
            Console.WriteLine(arr[fourthElIndex]);
            
            Console.WriteLine("----------End of Sample 2---------------");
        }

        private static void Sample3()
        {
            Console.WriteLine("--------------Sample 3------------------");
            
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var lastElIndex = new Index(1, true);
            Console.WriteLine(arr[lastElIndex]);
            
            Console.WriteLine("----------End of Sample 3---------------");
        }

        private static void Sample4()
        {
            Console.WriteLine("--------------Sample 4------------------");
            
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Index secondFromTheEndElIndex = ^2;
            Console.WriteLine(arr[secondFromTheEndElIndex]);
            
            Console.WriteLine("----------End of Sample 4---------------");
        }

        private static void Sample5()
        {
            Console.WriteLine("--------------Sample 5------------------");
            
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var fromSecondTillFifthRange = new Range(new Index(1), new Index(4));

            string result = string.Join(",", arr[fromSecondTillFifthRange]);
            Console.WriteLine(result);
            
            Console.WriteLine("----------End of Sample 5---------------");
        }

        private static void Sample6()
        {
            Console.WriteLine("--------------Sample 6------------------");
            
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            int[] fromThirdTillSixth = arr[2..6];

            string result = string.Join(",", fromThirdTillSixth);
            Console.WriteLine(result);
            
            Console.WriteLine("----------End of Sample 6---------------");
        }

        private static void Sample7()
        {
            Console.WriteLine("--------------Sample 7------------------");
            
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //int[] fromThirdTillSixth = arr[^1..0]; - Will throw ArgumentOutOfRangeException
            
            Console.WriteLine("----------End of Sample 7---------------");
        }

        private static void Sample8()
        {
            Console.WriteLine("--------------Sample 8------------------");
            
            var list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int secondFromTheEnd = list[^2];
            Console.WriteLine(secondFromTheEnd);
            
            Console.WriteLine("----------End of Sample 8---------------");
        }

        private static void Sample9()
        {
            Console.WriteLine("--------------Sample 9------------------");
            
            var list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //int secondFromTheEnd = list[2..4]; - Does not compile.
            
            Console.WriteLine("----------End of Sample 9---------------");
        }

        private static void Sample10()
        {
            Console.WriteLine("--------------Sample 10------------------");
            
            var firstName = "Volodymyr";
            string subStr = firstName[2..^2];
            Console.WriteLine(subStr);
            
            Console.WriteLine("----------End of Sample 10---------------");
        }

        private static void Sample11()
        {
            Console.WriteLine("--------------Sample 11------------------");
            
            var rangableList = new RangableList<int>(new[] {1, 2, 3, 4, 5});

            int fourthFromTheEnd = rangableList[^4];
            Console.WriteLine(fourthFromTheEnd);
            
            Console.WriteLine("----------End of Sample 11---------------");
        }

        private static void Sample12()
        {
            Console.WriteLine("--------------Sample 12------------------");
            
            var rangableList = new RangableList<int>();
            rangableList.Add(1, 2, 3, 4, 5);

            RangableList<int> newRangableList = rangableList[^1..^4];
            Console.WriteLine(newRangableList);
            
            Console.WriteLine("----------End of Sample 12---------------");
        }
    }
}