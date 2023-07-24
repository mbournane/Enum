using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    public class User
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Ecouleurs Couleur { get; set;}


        public void IntFromColor(string color)
        {
            if (color != null)
            {
                if(color.Equals(Ecouleurs.ROUGE.ToString()))
                {
                    Couleur = Ecouleurs.ROUGE;
                }else
            {
                if (color.Equals(Ecouleurs.VERT.ToString()))
                {
                    Couleur = Ecouleurs.VERT;
                }
                else
                {
                    if (color.Equals(Ecouleurs.BLEU.ToString()))
                    {
                        Couleur = Ecouleurs.BLEU;
                    }
                    else
                    {
                        if(color.Equals(Ecouleurs.JAUNE.ToString()))
                            Couleur = Ecouleurs.JAUNE;
                    }
                }
            }          
            }
            

        }

    }
}
