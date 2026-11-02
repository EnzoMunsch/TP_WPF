using System;
using System.Collections.Generic;
using System.Text;

namespace TP_WPF.NewFolder
{
    public class Ville
    {
        public string Nom { get; set; }
        public int Population { get; set; }
        public string Pays { get; set; }
        public string Drapeau { get; set; }

        public Ville(string nom, int population, string pays, string drapeau)
        {
            Nom = nom;
            Population = population;
            Pays = pays;
            Drapeau = drapeau;
        }
    }
}
