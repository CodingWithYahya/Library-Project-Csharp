using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Emsi
{
    internal class Livre : Ouvrage
    {
        public String auteur;
        public String titre;

        public Livre(string date, string num,string auteur,string titre) : base(date, num)
        {
            this.auteur = auteur;
            this.titre = titre;
        }
    }
}
