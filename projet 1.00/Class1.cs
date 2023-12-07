using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    internal class Fichierlettre
    {
        private Lettre[] tableau= new Lettre[26];
        public Lettre[] Tableau
        {
            get { return tableau; }
        }
        public void Lire(string nomfichier)
        {
            int i = 0;
            StreamReader flux = null;
            try
            {
                flux = new StreamReader(nomfichier);
                while((flux.ReadLine()) != null){
                    string[] ligne = flux.ReadLine().Split(',');
                    tableau[i] = new Lettre(ligne[0], Convert.ToInt32(ligne[1]), Convert.ToInt32(ligne[2]));
                }
            }
            finally
            {
                if( flux!= null)
                {
                    flux.Close();
                }
            }
           
        } 
    }
}
