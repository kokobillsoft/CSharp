using System;
namespace PalindromAndPerson.MicroProgramm.Convert
{
    public class FirstUpperLetterString
    {
        public static string StandartFormat(string wordWithoutConverting)
        {
            string convertingWord;
            char[] convertingWordCharArray;
            int i = 0;
            bool firstLetterIsLower = true;
            if (!String.IsNullOrEmpty(wordWithoutConverting))
            {
                convertingWordCharArray = wordWithoutConverting.ToCharArray();

                foreach (char letterInArray in convertingWordCharArray)
                { 
                    if (Char.IsLetter(letterInArray))
                    {
                        if (firstLetterIsLower)
                        {
                            Char.ToUpper(letterInArray);
                            firstLetterIsLower = false;
                        }
                        Char.ToLower(letterInArray);
                    }
                    i++;
                }
                convertingWord = convertingWordCharArray.ToString();
     
                return convertingWord;
            }
            return null;
        }
    }
}
