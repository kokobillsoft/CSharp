using System;
using System.Collections.Generic;

namespace TestForeach
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var fibNumbers = new List<string> { "Aa", "BB", "CC", "DD"};
            foreach (string alex in fibNumbers)
            {
                Console.Write(alex);
            }
        }
    }
}
