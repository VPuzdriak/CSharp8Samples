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
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var firstElIndex = new Index(0);
            Console.WriteLine(arr[firstElIndex]);
        }

        private static void Sample2()
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Index fourthElIndex = 3;
            Console.WriteLine(arr[fourthElIndex]);
        }

        private static void Sample3()
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var lastElIndex = new Index(1, true);
            Console.WriteLine(arr[lastElIndex]);
        }

        private static void Sample4()
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Index secondFromTheEndElIndex = ^2;
            Console.WriteLine(arr[secondFromTheEndElIndex]);
        }

        private static void Sample5()
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var fromSecondTillFifthRange = new Range(new Index(1), new Index(4));

            string result = string.Join(",", arr[fromSecondTillFifthRange]);
            Console.WriteLine(result);
        }

        private static void Sample6()
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            int[] fromThirdTillSixth = arr[2..6];

            string result = string.Join(",", fromThirdTillSixth);
            Console.WriteLine(result);
        }

        private static void Sample7()
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //int[] fromThirdTillSixth = arr[^1..0]; - Will throw ArgumentOutOfRangeException
        }

        private static void Sample8()
        {
            var list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int secondFromTheEnd = list[^2];
            Console.WriteLine(secondFromTheEnd);
        }

        private static void Sample9()
        {
            var list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //int secondFromTheEnd = list[2..4]; - Does not compile.
        }

        private static void Sample10()
        {
            var firstName = "Volodymyr";
            string subStr = firstName[2..^2];
            Console.WriteLine(subStr);
        }

        private static void Sample11()
        {
            var rangableList = new RangableList<int>(new[] {1, 2, 3, 4, 5});

            int fourthFromTheEnd = rangableList[^4];
            Console.WriteLine(fourthFromTheEnd);
        }

        private static void Sample12()
        {
            var rangableList = new RangableList<int>();
            rangableList.Add(1, 2, 3, 4, 5);

            RangableList<int> newRangableList = rangableList[^1..^4];
            Console.WriteLine(newRangableList);
        }
    }
}