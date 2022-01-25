using System;
using System.Collections.Generic;
using System.Linq;

namespace playtika_test
{
    class Program
    {

        static void Main(string[] args)
        {
            LevelTask.Test();

            Console.ReadKey();
        }
    }


    public class LevelTask
    {

        private static readonly Dictionary<int, int> levelMap = new Dictionary<int, int>()
        {
            [1] = 0,
            [2] = 100,
            [3] = 500,
            [4] = 1000,
            [5] = 4000,
            [6] = 10000
        };


        public static int FindLevel(int exp)
        {

            Console.WriteLine(levelMap.Keys.Last());

            foreach (int l in levelMap.Keys)
            {
                Console.WriteLine(l);
            }
            
            if (exp >=0)
            {
                if (exp >= 1000)
                {
                    if (exp >= 10000)
                    {
                        return 6;
                    }
                    else if (exp > 4000)
                    {
                        return 5;
                    }
                    return 4;
                }
                else if (exp >= 500)
                {
                    return 3;
                }
                else if (exp >= 100)
                {
                    return 2;
                }
                return 1;
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