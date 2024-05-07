using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSols
{
    internal class Program
    {
          static  Dictionary<char, string> phoneNumbers_Letters = new Dictionary<char, string>
            {
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"}

            };
      
        static void Main(string[] args)
        {

            var result = LetterCombinations("5678");

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
           

            Console.ReadKey();
        }

        private static IList<string> LetterCombinations(string digits)
        {
            List<string> lettersList = new List<string>();
            //"23"
            char Digit;
     
            for (int index = 0; index < digits.Length; index++)
            {
                Digit = digits[index];

                lettersList.Add(phoneNumbers_Letters[Digit]);
            }

            //return MixLetters(lettersList);
            return MixLettersList(lettersList);
        }

        private static List<string> MixLettersList(List<string> letters)
        {   
            List<string> collector = new List<string>();

            if(letters.Count == 1)
            {
                string x = letters[0];
               for (int i = 0; i < x.Length; i++)
                {
                    collector.Add(x[i].ToString());
                }
              

            }
            else if(letters.Count == 2)
            {

              collector = MixLetters(letters[0], letters[1]);
             

            }
            else if(letters.Count == 3)
            {
                collector = MixLetters(letters[0], letters[1], letters[2]);
            }
            else if(letters.Count == 4)
            {
                collector = MixLetters(letters[0], letters[1], letters[2], letters[3]);
            }
            else
            {
                return new List<string>();
            }
            return collector;
        }

        private static List<string> MixLetters(string first, string second)
        {
            var box = new List<string>();
            
            for (int i = 0; i < first.Length; i++) 
            {

                for(int j = 0 ; j < second.Length; j++)
                {
                    box.Add(first[i].ToString() + second[j].ToString());
                }

            }
            return box;
        }

        private static List<string> MixLetters(string first, string second, string third)
        {
            var box = new List<string>();

            for (int i = 0; i < first.Length; i++)
            {

                for (int j = 0; j < second.Length; j++)
                {
                    
                    for(int k  = 0; k < third.Length; k++)
                    {
                        box.Add(first[i].ToString() + second[j].ToString() + third[k].ToString());
                    }

                }

            }
            return box;
        }

        private static List<string> MixLetters(string first, string second, string third, string fourth)
        {
            var box = new List<string>();

            for (int i = 0; i < first.Length; i++)
            {

                for (int j = 0; j < second.Length; j++)
                {

                    for (int k = 0; k < third.Length; k++)
                    {
                        for (int l = 0; l < fourth.Length; l++)
                        {
                            box.Add(first[i].ToString() + second[j].ToString() + third[k].ToString() + fourth[l].ToString()) ;
                        }
                    }

                }

            }
            return box;
        }

    }
}
