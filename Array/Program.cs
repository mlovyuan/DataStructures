using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray = new ArraySample(20);
            for (int i = 0; i < 10; i++)
            {
                myArray.AddLast(i);
            }

            myArray.RemoveLast();
            Console.WriteLine(myArray.ToString());

            Show_Boxing_UnBoxing();

            Console.ReadKey();
        }

        private static void Show_Boxing_UnBoxing()
        {
            int times = 10000000;

            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Value Type Test: int");
            stopwatch.Start();
            List<int> list = new List<int>();
            for (int i = 0; i < times; i++)
            {
                list.Add(i); // No Boxing
                int temp = list[i]; // No UnBoxing
            }
            stopwatch.Stop();
            Console.WriteLine($"No Boxing and No UnBoxing Test, List<int> takes {stopwatch.ElapsedMilliseconds}ms");

            stopwatch.Restart();
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < times; i++)
            {
                arrayList.Add(i); // Boxing, cause int => object
                int temp = list[i]; // UnBoxing, cause object => int
            }
            Console.WriteLine($"Boxing and UnBoxing Test, ArrayList takes {stopwatch.ElapsedMilliseconds}ms/n");

            Console.WriteLine("Reference Type Test: string");
            stopwatch.Restart();
            List<string> list_s = new List<string>();
            for (int i = 0; i < times; i++)
            {
                list_s.Add("x"); // No Boxing
                string temp = list_s[i]; // No UnBoxing
            }
            stopwatch.Stop();
            Console.WriteLine($"No Boxing and No UnBoxing Test, List<string> takes {stopwatch.ElapsedMilliseconds}ms");

            stopwatch.Restart();
            ArrayList arrayList_s = new ArrayList();
            for (int i = 0; i < times; i++)
            {
                arrayList_s.Add("x"); // No Boxing
                string temp = arrayList_s[i] as string; // No UnBoxing
            }
            Console.WriteLine($"No Boxing and No UnBoxing Test, ArrayList takes {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}