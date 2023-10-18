using System;

namespace NombreCache
{
    class Program
    {
        static void Main(string[] args)
        {
            int valeur = 0, essai = 0, nb = 1;
            bool correct = false;
            // ajout d'un commentaire
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez un nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Vous devez saisir un nombre entier.");
                }
            }
            Console.Clear();
            correct = false;
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez un essai = ");
                    essai = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Vous devez saisir un nombre entier.");
                }
            }
            while (essai != valeur)
            {
                if (essai < valeur)
                {
                    Console.WriteLine("Trop petit !");
                }
                else
                {
                    Console.WriteLine("Trop grand !");
                }
                correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.Write("Entrez un essai = ");
                        essai = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Vous devez saisir un nombre entier.");
                    }
                }
                nb++;
            }
            Console.WriteLine("Bravo ! vous avez trouvé en "+nb+" fois");

        }
    }
}
