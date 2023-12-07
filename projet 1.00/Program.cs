using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

        }
        static void Afficher(string[,] matrice)
        {
            for (int l=0; l<matrice.GetLength(0); l++)
            {
                for (int c=0; c<matrice.GetLength(1) ; c++)
                {
                    Console.Write(matrice[l, c]);
                    Console.Write("");
                }
                Console.WriteLine("");
            }
        }
        static void Deplacer(string[,] matrice, int[,] coordonnées)
        {

        }
        static int[] Trouver(string[,] matrice, string mot) // va trouver la première occurence de la premiere lettre du mot, de gauche a droite bas vers haut
        {
            int[] retour = { -1, -1 };
            for (int l = matrice.GetLength(0) - 1; l > 0; l++)
            {
                for (int c=0;c<matrice.GetLength(1); c++)
                {
                    if (mot[0] == Convert.ToChar(matrice[l, c]))
                    {
                        retour[0] = l;                  
                        retour[1] = c;                          //manipulation pour n'avoir qu'un seul return.
                        break;
                    }
                }
            }
            return retour;
        }
        static string[,] Creer(Lettre[] tab)
        {
            string[,] retour = new string[8, 8];
            for (int l=0; l < 8; l++)
            {
                for (int c=0; c<8; c++)
                {
                    Random rnd = new Random();
                    
                    retour[l, c] = "//chercher fichier texte ligne rnd.Next(0, 27)";
                    //if (AjouterLettre(tab, "A") == true)
                    {

                    }
                }
            }
            return retour;
        }
        static void Autour(string[,] matrice, string mot, int[] coordonnees)
        {
            if (coordonnees[0] == 0)
            { 

            }
        }
    }
}

