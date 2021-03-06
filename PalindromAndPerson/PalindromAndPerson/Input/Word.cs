using System;
namespace PalindromAndPerson.Input
{
    public class Word
    {
        public static string LatinFromConsole()
        {
            string wordFromConsole;
            int counterOfWrongAnswer = 0;

            while (counterOfWrongAnswer < 5)
            {
                Console.WriteLine("Use only latin alphabet, without number or special symbol!");
                wordFromConsole = Console.ReadLine();
                if (!MicroProgramm.Check.Word.Latin.TrueORFalse(wordFromConsole))
                {
                    Console.WriteLine("\nInput ERROR!\n");
                    counterOfWrongAnswer++;
                }
                else
                {
                    return wordFromConsole;
                }
                
            }
            return null; 
        }
    }
}
