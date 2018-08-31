using System;

namespace Projet1
{
    class Program
    {
        // Initialisation des variables
        private static int valeur1 = 4;
        private static int valeur2 = 6;
        private static float reponse = 0;
        private static string operateur = "+/-/*/:";
        static void Main(string[] args)
        {
            // Sélection des champs
            /*Console.Write("Inscrivez le premier nombre.");
            valeur1 = int.Parse(Console.ReadLine());
            Console.Write("Inscrivez l'opérateur.");
            operateur = Console.ReadLine();
            Console.Write("Inscrivez le second nombre.");
            valeur2 = int.Parse(Console.ReadLine());*/

            Console.Write("\nRésultat de " + valeur1 + operateur + valeur2 + "\n");

            /*switch (operateur)
            {
                case "+": 
            }*/

            // Afficher addition
            reponse = additionner(valeur1, valeur2);
            Console.Write("\nAddition : " + reponse + "\n");

            // Afficher soustraction
            reponse = soustraction(valeur1, valeur2);
            Console.Write("Soustraction : " + reponse + "\n");

            // Afficher multiplication
            reponse = multiplication(valeur1, valeur2);
            Console.Write("Multiplication : " + reponse + "\n");

            // Afficher division, gère la division
            if (valeur2 == 0)
            {
                Console.Write("division par 0 impossible");
            }
            else
            {
                reponse = division(valeur1, valeur2);
                Console.Write("Division : " + reponse);
            }

            Console.ReadLine();
        }

        // Addition
        private static int additionner(int op1, int op2)
        {
            return op1 + op2;
        }
        // Soustraction
        private static int soustraction(int op1, int op2)
        {
            return op1 - op2;
        }
        // Multiplication
        private static int multiplication(int op1, int op2)
        {
            return op1 * op2;
        }
        // Division
        private static int division(int op1, int op2)
        {
            return op1 / op2;
        }
    }
}
