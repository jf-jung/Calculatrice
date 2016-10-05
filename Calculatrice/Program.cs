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

        static void Additioner()
        {
            float nombre1;
            float nombre2;
            float somme;

            nombre1 = SaisirFloat("Saisie premier nombre");
            nombre2 = SaisirFloat("Saisie second nombre");

            somme = nombre1 + nombre2;
            Console.WriteLine("La somme vaut : " + somme.ToString());
        }

        static void Main(string[] args)
        {
        }
    }
}
