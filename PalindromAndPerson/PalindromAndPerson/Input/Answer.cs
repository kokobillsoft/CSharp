using System;
namespace PalindromAndPerson.Input
{
    public class Answer
    {
        public static bool AnswerFromConsoleYOrN()
        {
            int wrongAnswerCount=0;
            string answerYN;
            Console.WriteLine("Enter Y=\"Yes\" or N=\"No\"");
            while (wrongAnswerCount < 5)
            {
                answerYN = Console.ReadLine();
                if (answerYN == "N")
                {
                    return false;
                }
                else if (answerYN == "Y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Your answer wrong!\nEnter Y=\"Yes\" or N=\"No\"?");
                    wrongAnswerCount++;
                }
            }
            Console.ReadLine();
            return false;
        }
    }
}
