using System;

namespace Banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);

            /*if (c1.superieur(c2))
            {
                Console.WriteLine("Supérieur !");

            }
            else
            {
                Console.WriteLine("Inférieur !");
            }*/
            Banque b = new Banque();
            b.AjouterCompte(c1);
            b.AjouterCompte(45657, "titi", 2000, -1000);
            //b.ToString();
            b.RendCompte(45657);

        }
    }
}
