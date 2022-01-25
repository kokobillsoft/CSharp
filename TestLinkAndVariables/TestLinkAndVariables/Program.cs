using System;

namespace TestLinkAndVariables
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(country1.x); // 7
            Console.WriteLine(country2.x); // 7

            Console.Read();
        }
        public static int ChangeCountry (Country country)
        {
            return 1;
        }
        struct State
        {
            public int x;
            public int y;
            public Country country;
        }
        class Country
        {
            public int x;
            public int y;
        }
    }
}
    
    

