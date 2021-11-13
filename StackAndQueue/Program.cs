using System;
using System.Diagnostics;
using StackAndQueue.Stack;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int testTimes = 10000000;
            Console.WriteLine($"Test times: {testTimes:N0}");

            long arrayStackTest = TestStack(new ArrayGenericStack<int>(testTimes), testTimes);
            Console.WriteLine($"ArrayStack's time: {arrayStackTest}ms");
            
            long linkedListStackTest = TestStack(new LinkedListStack<int>(), testTimes);
            Console.WriteLine($"LinkedListStackTest's time: {linkedListStackTest}ms");
            Console.ReadLine();
        }

        public static long TestStack(IStack<int> stack, int runTimes)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < runTimes; i++)
                stack.Push(i);
            for (int i = 0; i < runTimes; i++)
                stack.Pop();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
    }
}