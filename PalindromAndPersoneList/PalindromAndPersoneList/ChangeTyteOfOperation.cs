using System;
namespace PalindromAndPersoneList
{
    public class ChangeTyteOfOperation
    {
        public static void ChangeTyteOfOperation1()
        {
            string changeTypeOperation;
            Console.WriteLine("Please, change operation:\n Palindrom cheking -"+
                "enter P\n Persone list creating - enter L\n Your answer:");
            changeTypeOperation = Console.ReadLine();
            if (changeTypeOperation == "P" || changeTypeOperation == "p")
            {

            }
            else if (changeTypeOperation == "L" || changeTypeOperation == "l")
            {

            }
            else
            {
                Console.WriteLine("Your answer worng!!!\n" +
                "Please, change operation:\n Palindrom cheking - enter P\n Persone list creating - enter L");
            }

        }
    }
}
