using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    internal class Lettre
    {
        private int valeur;
        private int apparition;
        private int nombremax;
        private string nom;
        public Lettre(string noma, int nombra ,int valeura, int apparitiona)
        {
            valeur = valeura;
            apparition = apparitiona;
            nombremax = nombra;
            nom = noma;

        }
        public Lettre (string noma, int nombra, int valeura)
        {
            nom = noma;
            nombremax = nombra;
            valeur = valeura;
        }
        public bool AjouterLettre(Lettre[] tab, string nomb)             // renvoie true et ajoute la lettre une fois dans le tableau, false sinon 
        {
            bool retour = true;
            for (int i = 0; i == 26; i++)
            {
                if (tab[i].nom == nomb)
                {
                    if (tab[i].nombremax == tab[i].apparition)
                    {
                        retour = false;
                        Console.WriteLine("il y a deja le nombre maximal");
                    }
                    else
                    {
                        tab[i].apparition++;
                    }

                }
                else
                {
                    Console.WriteLine("la lettre n'existe pas");
                }
            }
            return retour;
        }
        public int Valeur
        {
            get { return valeur; }
        }
        public int Apparition
        {
            get { return apparition; }
        }
        public int Nombremax
        {
            get { return nombremax; }
        }
        public string Nom
        {
            get { return nom; }
        }
        public static string Tostring(Lettre a)
        {
            return a.nom;
        }
        

    }
}
