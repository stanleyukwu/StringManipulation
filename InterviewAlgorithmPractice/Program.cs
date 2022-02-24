using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace InterviewAlgorithmPractice
{
   public class Program
    {
        //Check max occurrence of a character in the string.

        public static char? MaxOccurrence(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            str = str.Trim().ToLower();

            int maxOccurenceValue = 0;
            char? maxOccurrenceChar = null; 

            char[] _charArr = str.ToCharArray();
            Dictionary<char, int> res = new Dictionary<char, int>();

            for(int i = 0; i < _charArr.Length; i++)
            {
               if(!char.IsWhiteSpace(_charArr[i]))
                {
                    if (!res.ContainsKey(_charArr[i]))
                    {
                        res.Add(_charArr[i], 1);
                    }
                    else
                    {
                        res[_charArr[i]]++;
                    }
                }
            }

            foreach(KeyValuePair<char,int> item in res) 
            {
                if(item.Value > maxOccurenceValue)
                {
                    maxOccurrenceChar = item.Key;
                    maxOccurenceValue = item.Value;
                  
                }
            }

            return (char)maxOccurrenceChar;

        }
        //Check if a string is a palindrome or not
        public static bool PalidromeCheck(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }
            word = word.Trim().ToLower();
            int min = 0;
            int max = word.Length - 1;
            while(max >= 0)
            {
                if(word[min] == word[max])
                {
                    min++;
                    max--;
                }
                else
                {
                    return false;
                }              
            }
            return true;
        }
        // Reverse a string

        public static string ReverseString(string str)
        {
            string result = "";
            if(string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            int n = str.Length - 1;
            for (int i = n; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }
        //Get the word count in a sentence (string)
        public static int GetWordCount(string sents)
        {
            sents = sents.Trim();
            string[] arr = sents.Split(" ");

            int count = 0;
            foreach(string ar in arr)
            {
                count++;
            }
            return count;
        }

        // Reverse each word of the sentence (string).

        public static string ReversEachWord(string sentence)
        {
            string newsentence = "";
           
            string temp = "";
            if (string.IsNullOrEmpty(sentence)) return string.Empty;
            
             string []words = sentence.Split("");
         
            for(int j = 0; j < words.Length; j++)
            {
             
                    for (int i = 0; i  < words[j].Length; i++)
                    {
                        temp += words[j][i];
                    }
                    newsentence =   ReverseString(temp) + " ";      

            }
          
            return newsentence;
        }
        //Get all possible substring in a string.
      
            
        static void Main(string[] args)
        {
            static void GetPossibleSubstring(string word)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        for (int j = 0; j <= word.Length - i; j++)
                        {
                            Console.WriteLine(word.Substring(j, i));
                        }
                    }


                }
            }

            // Reverse a string
            Console.WriteLine(ReverseString("Hello"));
            //Reverse each word of the sentence (string).
            Console.WriteLine(ReversEachWord("My name is mukesh"));

            //Get word count
            Console.WriteLine(GetWordCount(" Hello world"));

            //palidrome check
            Console.WriteLine(PalidromeCheck("rAdaRh"));

            //Max Occurence
            Console.WriteLine(MaxOccurrence("hello world"));

            //Get All possible occurrence

            GetPossibleSubstring("dog");
        }
    }
}
