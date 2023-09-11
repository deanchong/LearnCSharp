using System.Diagnostics;

namespace Scratch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            //var x = 9999996;

            //var n = 10000000;

            //var count = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    count++;

            //    if (i == x)
            //    {
            //        Console.WriteLine($"We found the value at \"{count}\" try" + "yay!");
            //        break;
            //    }

            //}

            Algo3 algo3 = new Algo3();

            int[] numCollection = new int[10000000];

            for (int i =1; i<numCollection.Length; i++)
            {
                numCollection[i] = i;
            }

            int high = numCollection.Length - 1;

            stopwatch.Start();

            algo3.FindNumber(numCollection, 0, high, 9999997);

            stopwatch.Stop();

            Console.WriteLine($"We found the value at \"{algo3.count}\" try");

            Console.WriteLine($"Time taken:{stopwatch.Elapsed:g}");
        }

        public class Algo3
        {
            public int count = 0;

            public int FindNumber(int[] collection, int start, int end, int x)
            {
                count++;

                if (end >= start)
                {
                    int mid = start + (end - start) / 2;
                    if (collection[mid] == x)
                    {
                        return mid;
                    }

                    if (collection[mid] > x)
                    {
                        return FindNumber(collection, start, mid - 1, x);
                    }

                    return FindNumber (collection, mid + 1, end, x);
                }

                return -1;
            }
        }
    }
}