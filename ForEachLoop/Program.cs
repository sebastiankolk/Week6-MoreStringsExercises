using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello World!";
            int count = 0;
            foreach(char c in word)
            {

                count++;
            }
            Console.WriteLine($"Lauses {word} on {count} sümbolit");

        }
    }
}
