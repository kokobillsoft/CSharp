using System;
namespace PalindromAndPerson.Input
{
    public class Name
    {
        public static string LatinFromConsole()
        {
            string nameFromConsole;
            string nameInStandartFormat;
            int counterOfWrongAnswer = 0;

            while (counterOfWrongAnswer < 5)
            {
                Console.WriteLine("Enter name\n");
                nameFromConsole = Input.Word.LatinFromConsole();
                if (nameFromConsole != null)
                {
                    if (nameFromConsole.Length > 1)
                    {
                       
                    }

                }
            }

            return null;
        }
    }
}
