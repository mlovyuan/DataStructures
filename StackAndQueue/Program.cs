using System;
using System.Collections.Generic;
using System.Diagnostics;
using StackAndQueue.Queue;
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
            
            
            testTimes = 100000;
            Console.WriteLine($"Test times: {testTimes:N0}");

            long arrayQueueTest = TestStack(new ArrayGenericQueue<int>(testTimes), testTimes);
            Console.WriteLine($"ArrayQueue's time: {arrayQueueTest}ms");
            
            long arrayCircularQueueTest = TestStack(new ArrayGenericCircularQueue<int>(), testTimes);
            Console.WriteLine($"ArrayCircularQueue's time: {arrayCircularQueueTest}ms");
            
            var cSharpQueueTest = new Queue<int>();
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < testTimes; i++)
                cSharpQueueTest.Enqueue(i);
            for (int i = 0; i < testTimes; i++)
                cSharpQueueTest.Dequeue();
            stopwatch.Stop();
            Console.WriteLine($"cSharpQueueTest's time: {stopwatch.ElapsedMilliseconds}ms");


            long linkedListQueueTest = TestStack(new LinkedListGenericQueue<int>(), testTimes);
            Console.WriteLine($"ArrayQueue's time: {linkedListQueueTest}ms");

            long linkedListCircularQueueTest = TestStack(new LinkedListGenericCircularQueue<int>(), testTimes);
            Console.WriteLine($"LinkedListCircularQueueTest's time: {linkedListCircularQueueTest}ms");
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
        
        public static long TestStack(IQueue<int> queue, int runTimes)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < runTimes; i++)
                queue.Enqueue(i);
            for (int i = 0; i < runTimes; i++)
                queue.Dequeue();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
    }
}