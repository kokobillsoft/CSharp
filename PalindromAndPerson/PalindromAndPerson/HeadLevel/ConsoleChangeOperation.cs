using System;
namespace PalindromAndPerson.HeadLevel
{
    public class ConsoleChangeOperation
    {
        public static bool ChangeOperation()
        {
            string curentChangeOperation;
            int wrongAnswerCount = 0;
            Console.WriteLine("Do yo want begin \"Palindrom check\" or \"Create perones list\"?");
            // Console.WriteLine(Input.Answer.AnswerFromConsoleYOrN());
            if (Input.Answer.AnswerFromConsoleYOrN())
            {   
                while (wrongAnswerCount < 5)
                {
                    Console.WriteLine("Change action. Enter key for continue\n" +
                     "Palindrom check - \"1\"\n" +
                     "Create persones list - \"2\"");
                    curentChangeOperation = Console.ReadLine();
                    switch (curentChangeOperation)
                    {
                        case "1":
                            if (!MicroProgramm.Check.Palindrome.AnswerTo.WinConsole())
                            {
                                Console.WriteLine("\nPalindrome word check failed\n\n");
                            }
                            Console.WriteLine("\nPalindrome word check complited\n\n");
                            wrongAnswerCount = 0;
                            break;

                        case "2":
                       //     MicroProgramm.Create.List.Persones.New.NewList();
                            wrongAnswerCount = 0;
                            break;

                        default:
                            Console.WriteLine("\nYour answer wrong!\n");
                            wrongAnswerCount++;
                            break;
                    }
            
                }
                
            }
            return false;
        }
    }
}
