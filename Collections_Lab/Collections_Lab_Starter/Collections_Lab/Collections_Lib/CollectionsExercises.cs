using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
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
            else if (num > queue.Count)
            {
                for (int i = 0; i < queue.Count; i++)
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
            //Refactoring:      return result[0..^2];
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            int[] resultArray = new int[original.Length];
            Stack<int> intStack = new Stack<int>();

            foreach (int i in original)
            {
                intStack.Push(i);
            }

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = intStack.Pop();
            }
            return resultArray;
         }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            Dictionary<char, int> numDictionary = new Dictionary<char, int>();
            var output = "";

            foreach (var c in input)
            {
                if (int.TryParse(c.ToString(), out _))
                {
                    if (numDictionary.ContainsKey(c))
                    {
                        numDictionary[c]++;
                    }
                    else
                    {
                        numDictionary.Add(c, 1);
                    }
                }
            }
            foreach (var keyValuePair in numDictionary)
            {
                output += keyValuePair;
            }
            return output;
        }
    }
}
