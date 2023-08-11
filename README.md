## Fonction de demande d'un nombre entier à l'utilisateur

### Introduction

Ce répertoir va présenter une fonction qui permet de demander à l'utilisateur de saisir un nombre entier. La fonction possède 4 paramètre optionnel comme le minimum a saisir le maximum et le message afficher.

Code : [Projet]()

Application : [Console.exe]()

logiciel : [Visual studio 2022](https://visualstudio.microsoft.com/fr/)

### main 

Le main va utiliser le fonction dans différent cas comme sans modifié les paramètres ou en les changeant et même les cas d'erreur avec un minimum suppérieur au maximum.

~~~C#

        static void Main(string[] args)
        {
            /*
             * Ce programme montre une fonction
             * de demande utilisateur modulable
             * pour des entiers.
             * 
             * Jérémy Clémente 10/02/2023
             */

            //Variable

            int Nbre;

            //Initialisation


            //Début

            //demande sans changement
            Nbre = Demande_int();

            Console.WriteLine("La valeur saisie est : " + Nbre);

            //changement Min Msg et Msg_erreur
            Nbre = Demande_int(Min:0, Msg: "Veuillez Saisir un entier positif.", Msg_erreur:"Vous devez saisir une entier positif (0 ou plus).");

            Console.WriteLine("La valeur saisie est : " + Nbre);

            //Cas Min > Max
            Nbre = Demande_int(Min: 0, Max:-5);

            Console.WriteLine("La valeur saisie est : " + Nbre);

            //Fin
        }

~~~
