using System;

namespace functions
{
    class Program
    {
        static string nom = "steve";
        static void Main(string[] args)
        {

            Console.WriteLine("Lancer");
            DireBon(nom);
        }

        static void DireBon(string nom)
        {
            Console.WriteLine("BOnjour" + nom);
        }
    }
}
