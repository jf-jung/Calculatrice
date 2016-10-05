using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static float SaisirFloat(string prompt)
        {
            string reponse;
            Console.WriteLine(prompt);
            reponse = Console.ReadLine();
            return float.Parse(reponse);
        }

        static void Menu()
        {
            string operation;
            Console.WriteLine("Choisissez votre opération");
            operation = Console.ReadLine();
            while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.WriteLine("Opération invalide. Choississez une opération supportée");
                operation = Console.ReadLine();
            }
            if (operation == "+")
            {
                Additioner();
            }
            if (operation == "-")
            {
                Soustraire();
            }
            if (operation == "*")
            {
                Multiplier();
            }
            if (operation == "/")
            {
                Diviser();
            }
        }

        static void Additioner()
        {
            float nombre1;
            float nombre2;
            float resultat;

            nombre1 = SaisirFloat("Saisie premier nombre");
            nombre2 = SaisirFloat("Saisie second nombre");

            resultat = nombre1 + nombre2;
            Console.WriteLine("La somme vaut : " + resultat.ToString());
        }

        static void Soustraire()
        {
            float nombre1;
            float nombre2;
            float resultat;

            nombre1 = SaisirFloat("Saisie premier nombre");
            nombre2 = SaisirFloat("Saisie second nombre");

            resultat = nombre1 - nombre2;
            Console.WriteLine("La différence vaut : " + resultat.ToString());
        }

        static void Multiplier()
        {
            float nombre1;
            float nombre2;
            float resultat;

            nombre1 = SaisirFloat("Saisie premier nombre");
            nombre2 = SaisirFloat("Saisie second nombre");

            resultat = nombre1 * nombre2;
            Console.WriteLine("Le produit vaut : " + resultat.ToString());
        }

        static void Diviser()
        {
            float nombre1;
            float nombre2;
            float resultat;

            nombre1 = SaisirFloat("Saisie premier nombre");
            nombre2 = 0;
            while (nombre2 == 0)
            {
                nombre2 = SaisirFloat("Saisie second nombre");
            }
            

            resultat = nombre1 / nombre2;
            Console.WriteLine("Le résultat vaut : " + resultat.ToString());
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
