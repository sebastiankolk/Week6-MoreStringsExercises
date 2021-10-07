using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonna nimi");
            string perekonnanimi = Console.ReadLine();
            string nimi = $"{eesnimi}{perekonnanimi}";
            int count = 0;
            foreach (char c in nimi)
            {

                count++;
            }
            Console.WriteLine($"Sinu nimes on {count} sümbolit.");
        }
    }
}
