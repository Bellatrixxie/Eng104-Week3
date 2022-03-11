using System;
using System.Collections.Generic;

// I create a new Solution for debugging Collections_Lab Methods

namespace Collections_ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var reversed = new int[] { 1, 2, 3 };

            //foreach (int i in reversed)
            //{
            //    Console.WriteLine(reversed[i]);
            //}

            var _queue = new Queue<string>();
            _queue.Enqueue("Cathy");
            _queue.Enqueue("Jim");
            _queue.Enqueue("Petra");
            _queue.Enqueue("Moxie");
            _queue.Enqueue("Petunia");
            //Console.WriteLine(_queue.Count);
            //Console.WriteLine(7 > _queue.Count);

            Console.WriteLine(NextInQueue(6, _queue));

        }
        public static string NextInQueue(int num, Queue<string> queue)
          {
            string result = "";

            if (num == 0)
            {
                return result;
            }
            else if (num == 1)
            {
                return queue.Dequeue();
            }
            else if (num >= queue.Count)
            {
                for (int i = 0; i <= queue.Count; i++)
                {
                    result += queue.Dequeue() + ", ";
                  }
                return result += queue.Dequeue();
            }
            else
            {
                for (int i = 1; i < num; i++)
                {
                    result += queue.Dequeue() + ", ";
                }
                return result += queue.Dequeue();
            }
         }

        public static int[] Reverse(int[] original)
        {
            int[] resultArray = new int[original.Length];
            Stack<int> intStack = new Stack<int>();

            foreach (int i in original)
            {
                intStack.Push(original[i]);
            }

            foreach (int space in resultArray)
            {
                resultArray[space] = intStack.Pop();
            }
            return resultArray;
        }
    }
}