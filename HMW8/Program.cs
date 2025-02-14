using System;
using System.Linq;

namespace HMW8
{
    class Program
    {
        static string CaesarShift(string filePath, int offset)
        {
            string output = "";                                                     // initially an empty string
            try
            {
                using (StreamReader sr = new StreamReader(filePath))                // file reading
                {
                    string content = sr.ReadToEnd().ToLower();
                    foreach (char c in content)                                     // reading content character by character
                    {
                        int o = offset;
                        if (char.IsLetter(c))                                       // if character is a letter, then shift by offset
                        {
                            int ord = (int)c;
                            if (ord > 96 && ord < 123)
                            {
                                if (ord + o > 122)
                                {
                                    int ch = ord;
                                    while (ch < 123)
                                    {
                                        ch++;
                                        o--;
                                    }
                                    ch = 97;
                                    while (o > 0)
                                    {
                                        ch++;
                                        o--;
                                    }
                                    output += (char)ch;
                                }
                                else
                                {
                                    output += (char)(ord + o);
                                }
                            }
                            else
                            {
                                output += c;
                            }
                        }
                        else
                        {
                            output += c;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error: " + exc.Message);
            }
            return output;
        }
        static void count(string text, Dictionary<char, int> frequency)
        {
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    if (frequency.ContainsKey(c))
                    {
                        frequency[c]++;
                    }
                    else
                    {
                        frequency[c] = 1;
                    }
                }
            }
        }
        static string frequencyAnalysis(Dictionary<char, int> frequency, string crypted)
        {
            var sorted = frequency.OrderByDescending(x => x.Value);         // dictionary sorted by value
            var c1 = sorted.ElementAt(0);                                   // most frequent character in the encrypted content
            int offset = (int)c1.Key - 101;                                 // in the English language 'e' = 101 is the most used letter
            string output = "";                                             // initially an empty string
            // start the decryption
            foreach (char c in crypted)
            {
                int o = offset;
                if (char.IsLetter(c))
                {
                    int ord = (int)c;
                    if (ord > 96 && ord < 123)
                    {
                        if (ord - o < 97)
                        {
                            int ch = ord;
                            while (ch > 96)
                            {
                                ch--;
                                o--;
                            }
                            ch = 122;
                            while (o > 0)
                            {
                                ch--;
                                o--;
                            }
                            output += (char)ch;
                        }
                        else
                        {
                            output += (char)(ord - o);
                        }
                    }
                    else
                    {
                        output += c;
                    }
                }
                else
                {
                    output += c;
                }
            }
            return output;
        }
        static void Main(String[] args)
        {
            string filePath = "text.txt";                                               // Dante Alighieri's Inferno
            int offset = new Random().Next(1, 25);                                      // random shift
            Console.WriteLine("Executing Caesar shift...");
            string crypted = CaesarShift(filePath, offset);
            Console.WriteLine(crypted);
            Console.WriteLine("\n\nExecuting decryption with frequency analysis...");
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            count(crypted, frequency);
            Console.WriteLine(frequencyAnalysis(frequency, crypted));
        }
    }
}