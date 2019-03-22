using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write a function to perform basic string compression using the counts of repeated characters");
            var input = Console.ReadLine();

            //input = "aabcccccaaa"; 
            var message = process(input);
            
            Console.WriteLine(message);
            Console.ReadLine();
        }

        private static bool validate(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        public static string process(string input)
        {
            if (!validate(input))            
                return "Invalid input";
            var list = input.ToList();
            var x = 0;
            char car = list[0];
            var count = 0;
            var charCnt = new List<ListCount>();
            for (int i = 0; i < input.Length; i++)
            {
                if (car == list[i])
                    count++;
                else
                {
                    addToList(ref count, car, ref charCnt);
                    car = list[i];
                }
                x++;
            }
            addToList(ref count, list[x -1], ref charCnt);
            var retVal = string.Empty;
            foreach (ListCount result in charCnt)
                retVal += $"{result.count}{result.character}";
            return retVal;
        }

        private static void addToList(ref int count, char character, ref List<ListCount> charCount)
        {
            var lstCount1 = new ListCount();
            lstCount1.count = count;
            lstCount1.character = character;
            charCount.Add(lstCount1);
            count = 1;            
        }
    }
}
