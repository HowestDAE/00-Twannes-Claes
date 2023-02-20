using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            //Console.WriteLine("Hello world");
            //Console.WriteLine("What's your name");
            //string input = Console.ReadLine();
            //
            //Console.WriteLine($"Hello {input}");
            //Console.ReadLine();
            #endregion

            #region 02
            //Console.WriteLine("Enter a sequence of number seperated by space");
            //
            //string[] array = Console.ReadLine().Split(' ');
            //
            //double sum = 0, product = 1;
            //
            //foreach(string s in array)
            //{
            //    double number = Convert.ToDouble(s);
            //    sum += number;
            //    product *= number;
            //}
            //
            //Console.WriteLine($"Sum: {sum} ");          
            //Console.WriteLine($"Product: {product} ");      
            //Console.ReadLine();
            #endregion

            #region 03

            //Console.WriteLine("Enter a sentence");
            //
            //String  sentence = Console.ReadLine();
            //
            //string[] array = { };
            //
            //string word = string.Empty;
            //
            //int amountDigt = 0;
            //int amountLetter = 0;
            //int amountPunctuation = 0;
            //int amountSymbol = 0;
            //
            //for(int i = 0; i < sentence.Length;i++)
            //{
            //    char c = sentence[i];
            //
            //    if (char.IsLetter(c))
            //    {
            //        word += c;
            //        amountLetter++;
            //    }
            //    if((c == ' ' && word != string.Empty) || i == sentence.Length -1)
            //    {
            //        int index = sentence.IndexOf(word);
            //        Console.WriteLine($"word: \'{word}\' at {index} length {word.Length}");
            //        array.Append( word );
            //        word = string.Empty;
            //    }
            //    if(char.IsDigit(c))
            //    {
            //        amountDigt++;
            //    }
            //    if (char.IsPunctuation(c))
            //    {
            //        amountPunctuation++;
            //    }
            //    if (char.IsSymbol(c))
            //    {
            //        amountSymbol++;
            //    }
            //}
            //
            //Console.WriteLine("New sentence:");
            //
            //foreach (string s in array)
            //{
            //    s.Reverse();
            //    Console.Write($"{s} ");
            //}
            //
            //Console.WriteLine();
            //Console.WriteLine($"{amountDigt} digit characters");
            //Console.WriteLine($"{amountLetter} letter characters");
            //Console.WriteLine($"{amountPunctuation} punctuation characters");
            //Console.WriteLine($"{amountSymbol} symbol characters");
            //
            //Console.ReadLine();

            #endregion

            #region 04

            Console.WriteLine("Guess a number between 0 - 9");

            Random randomGen = new Random();

            int number = randomGen.Next(0,10);

            int guess = 0;

            int tries = 0;

            Console.Write("Your number: ");
            guess = Convert.ToInt32(Console.ReadLine());
            tries++;

            while (guess != number)
            {
                Console.Write("Your number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                tries++;
            }

            Console.WriteLine($"You found the number {number} after {tries} tries");
            Console.ReadLine();

            #endregion
        }
    }
}
