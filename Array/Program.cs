using System;

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
            Console.ReadKey();
        }
    }
}