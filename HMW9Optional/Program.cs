using System;
using System.Collections.Generic;

namespace HMW9Optional
{
    class Program
    {
        static List<char> from = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        static List<char> to = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        static void substitution(List<(char, char)> mapping)
        {
            foreach (char c in from)
            {
                int index = new Random().Next(0, to.Count());
                mapping.Add((c, to[index]));
                to.RemoveAt(index);
            }
        }
        static string encryption(List<(char, char)> mapping, string str)
        {
            string output = "";
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    output += mapping.FirstOrDefault(tuple => tuple.Item1 == c).Item2;
                }
                else
                {
                    output += c;
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            List<(char, char)> mapping = new List<(char, char)>();
            substitution(mapping);
            foreach (var item in mapping)
            {
                Console.WriteLine(item.Item1 + " -> " + item.Item2);
            }
            Console.WriteLine("\nDigit something: ");
            string input = Console.ReadLine();
            Console.WriteLine("Encrypted string: " + encryption(mapping, input.ToLower()));
        }
    }
}