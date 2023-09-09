using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demande_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ce programme montre une fonction
             * de demande utilisateur modulable
             * pour des entiers.
             * 
             * Jérémy Clémente 10/02/2023
             * https://github.com/J3R5/Demande_int/tree/main
             */

            //Variable

            int Nbre;

            //Initialisation


            //Début

            //demande sans changement
            Nbre = Demande_int();

            Console.WriteLine("La valeur saisie est : " + Nbre);

            //changement Min Msg et Msg_erreur
            Nbre = Demande_int(Min:0, Msg: "Veuillez Saisir un entier positif.", Msg_erreur:"Vous devez saisir un entier positif (0 ou plus).");

            Console.WriteLine("La valeur saisie est : " + Nbre);

            //Cas Min > Max
            Nbre = Demande_int(Min: 0, Max:-5);

            Console.WriteLine("La valeur saisie est : " + Nbre);

            //Fin
        }

        static int Demande_int
            (int Min = int.MinValue,
             int Max = int.MaxValue,
             string Msg = "Veuillez Saisir un entier.",
             string Msg_erreur = "Vous devez saisir un entier")
        {
            /*
             * fonction
             * de demande utilisateur modulable
             * pour des entiers.
             * 
             * Jérémy Clémente 10/08/2023
             * https://github.com/J3R5/Demande_int/tree/main
             */

            //Variable

            string Saisie;
            int Nbre;
            bool Conversion;

            //Initialisation

            Saisie = null;
            Nbre = 0;
            Conversion = false;

            //Début

            Console.WriteLine();

            //vérification plage Min à Max
            if (Min > Max)
            {
                Console.WriteLine("Erreur : la fonction ne peut pas être utilisée la valeur maximum est suppérieure au minimum ");
                return 1; // 1 est une valeur par défaut en cas de plage de mesure incorrecte
            }
            else
            {
                //demande de la valeur
                do
                {
                    Console.WriteLine(Msg);
                    Saisie = Console.ReadLine();
                    Conversion = int.TryParse(Saisie, out Nbre);
                    if (Conversion == false || Nbre < Min || Nbre > Max)
                    {
                        Console.WriteLine(Msg_erreur);
                    }
                } while (Conversion == false || Nbre < Min || Nbre > Max);
                //si la valeur est incorrecte, on recommence
            }

            return Nbre;

            //Fin
        }
    }
}
