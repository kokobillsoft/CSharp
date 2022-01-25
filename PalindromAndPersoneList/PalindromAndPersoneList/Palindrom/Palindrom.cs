using System;
namespace PalindromAndPersoneList.Palindrom
{
    public class Palindrom
    {
        public Palindrom()
        {
            string wordFromConsole;
            char[] wordFromConsoleCharArray;
            bool equalMark = true;
            bool markOfWorkingProgramm = true;
            bool markOfNewWordCheck = true;
            Console.WriteLine("Palindrom word check\n");
            while (markOfWorkingProgramm)
            {
                Console.WriteLine("Enter word\n");
                wordFromConsole = Console.ReadLine();
                wordFromConsoleCharArray = wordFromConsole.ToCharArray();
                for (int i = 0; i < (wordFromConsoleCharArray.Length / 2); i++)
                {
                    if (Char.IsLetter(wordFromConsoleCharArray[i])
                    {
                        if (wordFromConsoleCharArray[i] != wordFromConsoleCharArray[wordFromConsoleCharArray.Length - 1 - i])
                        {
                            equalMark = false;
                            break;
                        }
                    }
                }
            }
        }
    }
}


