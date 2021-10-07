using System;

namespace SubstituteCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonna nimi");
            string perekonnanimi = Console.ReadLine();
            string nimi = $"{eesnimi} {perekonnanimi}";
            nimi = nimi.Replace('a', '*');
            Console.WriteLine(nimi);
        }
    }
}
