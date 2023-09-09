## Fonction de demande d'un nombre entier à l'utilisateur

### Introduction

Ce répertoire va présenter une fonction qui permet de demander à l'utilisateur de saisir un nombre entier. La fonction possède 4 paramètres optionnels comme le minimum à saisir, le maximum et le message affiché.

Code : [Projet](https://github.com/J3R5/Demande_int/tree/main/Executable)

Application : [Console.exe](https://github.com/J3R5/Demande_int/tree/main/Executable)

Logiciel : [Visual studio 2022](https://visualstudio.microsoft.com/fr/)

### main 

Le main va utiliser le fonction dans différents cas comme sans modifier les paramètres ou en les changeant et même le cas d'erreur avec un minimum supérieur au maximum.

~~~C#

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

~~~

Tout le long du programme, on va se servir de la variable Nbre. La première fois que l'on utilise la fonction, on ne change aucun paramètre. Puis, on affiche le résultat dans la console pour montrer que la fonction renvoit bien la bonne valeur.

Dans le deuxième cas, on modifie le minimum ainsi que la variable du message affiché et le message d'erreur. Dans ce cas, la fonction sera configurée pour renvoyer un entier positif et rejetera tous les autres nombres négatifs ou réels non entier ; ainsi que les chaînes de caractères. Ensuite, on affiche le nombre comme précédemment dans la console.

Le troisième et dernier exemple montre un cas d'erreur d'utilisation de la fonction où l'on a le minimum supérieur au maximum et donc aucun intervale pour saisir un nombre. Dans ce cas, la fonction envoit un message d'erreur et renvoit 1 comme valeur par défaut.

### Demande_int()

~~~C#

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
                Console.WriteLine("Erreur : la fonction ne peut pas être utilisée la valeur maximum est supérieur au minimum ");
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
                //si la valeur est incorrect, on recommence
            }

            return Nbre;

            //Fin
        }

~~~

La fonction prend en paramètre 4 paramètres optionnels qui sont : Min, Max, Msg et Msg_erreur.

Min (entier) : valeur minimum de la plage de valeur à saisir. Par défaut la valeur est la plus petite possible.

Max (entier) : valeur maximum de la plage de valeur à saisir. Par défaut la valeur est la plus grande possible.

Msg (chaîne de caractère) : Message à afficher pour aider l'utilisateur pour savoir ce qu'il doit saisir.

Msg_erreur (chaîne de caractère) : Message qui s'affiche en cas d'erreur de saisie de l'utilisateur.

Le programme possède 3 variables interne Saisie, Nbre et Conversion.

Saisie (chaine de caractère) : Contient ce que l'utilisateur va saisir dans la console. 

Nbre (entier) : Nombre que l'utilisateur va saisir.

Conversion (booléen) : variable qui permet de savoir si la conversion de Saisie en entier a réussi.

Le Début du programme vérifie que le Min est plus petit que Max pour avoir une plage de saisie, si Min est plus grand que Max alors on affiche un message d'erreur et on renvoit 1. Il est préférable de renvoyer 1 au lieu de 0 en cas de division, 0 serait dangereux.

Si il existe une plage de mesure, on rentre dans une boucle où l'on affiche le message de saisie puis, l'utilisateur va rentrer un nombre qui va aller dans la variable Saisie. Ensuite, on essaye de convertir la saisie en nombre via la fonction int.tryparse() si elle réussit la variable conversion passera à true, sinon elle est à false. Si la conversion a échoué ou que le nombre n'est pas dans la plage plus petit que le minimum ou plus grand que le maximum, on recommence la saisie en affichant le message d'erreur de saisie.

Une fois un nombre valide entré, on quitte la boucle et la fonction renvoit ce nombre.

### Conclusion 

Cette fonction permet de saisir un nombre entier en personnalisant la plage de saison et les messages affichés. Elle ne permet pas la saisie de nombre réel ou flottant.



