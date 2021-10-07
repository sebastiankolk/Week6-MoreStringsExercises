using System;

namespace MituSona
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world!";
            /*int i = 0;
            int counter = 1;
            
            while(i < text.Length)
            {
                if(text[i] == ' ')
                {
                    counter++;
                }
                i++;
            }
            Console.WriteLine($"Lauses {text} on {counter} sõna");*/
            int counter = 1;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    {
                        counter++;
                    }
            }
            Console.WriteLine($"Lauses {text} on {counter} sõna");
        }
    }
}
