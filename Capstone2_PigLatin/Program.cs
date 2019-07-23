using System;

namespace Capstone2_PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {


            bool translateAgain = true;
            do
            {
                string userString = GetInput("Please enter some text to be translated: ");
                TranslatePigLatin(userString);
                Console.WriteLine();
                string againInput = "";
                while(againInput != "y" && againInput != "n")
                {
                    againInput = GetInput("Would you like to play again? y/n: ");
                }
                if (againInput == "n")
                {
                    translateAgain = false;
                }




            } while (translateAgain);
            Console.WriteLine("Oodgay Yebay!");

        }

        public static string GetInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine().ToLower();
            if (input == "")
            {
                return GetInput("That is not an input. Please try again: ");
            }
            else
            {
                return input;
            }
        }

        public static void TranslatePigLatin(string message)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            string[] inputArray = message.Split(" ");
            int length = inputArray.Length;
           

            foreach (string word in inputArray)
            {
                 
               int indexNum = word.IndexOfAny(vowels);
               if (indexNum == 0)
               {
                    TranslateVowel(word); 
               }
               else if (indexNum > 0)
               {
                    TranslateConsonant(word, indexNum);
               }
               else
               {
                   Console.Write(word +" ");
               }

               

            }

        }
        public static void TranslateConsonant(string word, int indexNum)
        {
            string consonantFirst = "ay";
            string substring1 = word.Substring(0, indexNum);
            string substring2 = word.Substring(indexNum);
            string consonantPigLatin = substring2 + substring1 + consonantFirst;
            Console.Write(consonantPigLatin + " ");
        }
        public static void TranslateVowel(string word)
        {
            string vowelFirst = "way";
            string vowelPigLatin = word + vowelFirst;
            Console.Write(vowelPigLatin + " ");

        }

    }
}
