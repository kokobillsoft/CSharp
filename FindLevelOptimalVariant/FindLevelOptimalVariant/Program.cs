using System;
using System.Collections.Generic;
using System.Linq;

namespace playtika_test
{
    class Program
    {

        static void Main(string[] args)
        {
            LevelTask.FindLevel(1);

            Console.ReadKey();
        }
    }


    public class LevelTask
    {

        private static readonly Dictionary<int, int> levelMap = new Dictionary<int, int>()
        {
            [4] = 0,
            [2] = 100,
            [5] = 500,
            [1] = 1000,
            [3] = 4000,
            [6] = 10000
        };


        public static int FindLevel(int exp)
        {
            if (!levelMap.ContainsValue(exp))
            {
                var sortedDicktByValue = from z in levelMap
                                         orderby levelMap.Values
                                         select z;

            }
            else
            {
                return levelMap.K
            }
            

            foreach (KeyValuePair<int, int> keyValuePair in sortedDicktByValue)
            {
                Console.WriteLine(keyValuePair);
            }

            return -1;
        }

        public static void Test()
        {
            Console.WriteLine($"For 0 exp: {FindLevel(0)} should be 1");
            Console.WriteLine($"For 50 exp: {FindLevel(50)} should be 1");
            Console.WriteLine($"For 120 exp: {FindLevel(120)} should be 2");
            Console.WriteLine($"For 1000 exp: {FindLevel(1000)} should be 4");
            Console.WriteLine($"For 600 exp: {FindLevel(600)} should be 3");
            Console.WriteLine($"For 21000 exp: {FindLevel(21000)} should be 6");
        }

    }
}