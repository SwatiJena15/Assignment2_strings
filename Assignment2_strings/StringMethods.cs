using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_strings
{
    public class StringMethods
    {
        //Count no. of characters in the sentence
        public int Countcharacters(String sentence)
        {
            int len = sentence.Replace(" ", "").Length;
            Console.WriteLine($"the number of character in sentence is : {len}");
            return len;
        }

        //Count no. of words in a sentence
        public void Countwords(String sentence)
        {
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"the number of words in sentence is : {words.Length}");
        }

        //Reverse a sentence
        public void Reverse(String sentence)
        {
            string[] words = sentence.Split(' ');
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
        }
        //Check whether the sentence is palindrome or not
        public void Palindrome(String sentence)
        {
            string[] words = sentence.Split(' ');
            if (words.SequenceEqual(words.Reverse()))
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
        }

        //Count number of vowels, consonants , integers and special characters in the sentence.
        //sathwika
        public void CountSentence(String sentence)
        {
            int vowels = 0, consonants = 0, digits = 0, specialCharacters = 0;
            foreach (char c in sentence)
            {
                if ("aeiouAEIOU".Contains(sentence))
                {


                    vowels++;

                }
                else if (Char.IsLetter(c))//consonant
                {

                    consonants++;

                }
                else if (Char.IsDigit(c))//digit
                {
                    Console.WriteLine("\nThe character is an integer.");
                    digits++;
                }
                else
                {
                    Console.WriteLine("\nThe character is a special character.");
                    specialCharacters++;
                }

            }
            Console.WriteLine($"Vowels: {vowels}");
            Console.WriteLine($"Consonants: {consonants}");
            Console.WriteLine($"Digits: {digits}");
            Console.WriteLine($"Special Characters: {specialCharacters}");

        }


    }
}

