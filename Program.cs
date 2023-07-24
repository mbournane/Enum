using System.Drawing;

namespace Enumeration;

class Program
{
    
    static void Main(string[] args)
    {
         List<User> users = new List<User>();
        User user = new User();
        bool saisie = true;
        while (saisie)
        {
            Console.WriteLine("Saisir un nom :");
            user.Nom = Console.ReadLine();

            Console.WriteLine("Saisir un Prénom :");
            user.Prenom = Console.ReadLine();
            Console.WriteLine("Veullez saisir une couleurs parmis les couleurs ci-dessous!");
            Console.WriteLine(StringFromColor(Ecouleurs.ROUGE));
            Console.WriteLine(StringFromColor(Ecouleurs.BLEU));
            Console.WriteLine(StringFromColor(Ecouleurs.VERT));
            Console.WriteLine(StringFromColor(Ecouleurs.JAUNE));

            string couleur = Console.ReadLine();
            user.IntFromColor(couleur);

            users.Add(user);
            Console.WriteLine("Voulez vous saisir un autre utilisateur (y/n)?");
            string yesNo = Console.ReadLine();
            if (yesNo == "yes")
                saisie = true;
            else saisie = false;

        }
        Console.WriteLine("la liste des utilisateurs:");
        foreach(User usr in  users) 
        {
            Console.WriteLine("Nom: " + usr.Nom);
            Console.WriteLine("Prénom: "+ usr.Prenom);
            Console.WriteLine("Couleur : " + usr.Couleur);
        }
        foreach (string c in Enum.GetNames(typeof(Ecouleurs)))
        {
            int count = 0;
            foreach (User usr in users)
            {
                
                if(usr.Couleur.ToString() == c)
                {
                    count++;
                }
                
                    
            }
            Console.WriteLine("pour la couler " + c + " le nombre d'utilisateurs " + count);
        }

         


    }
    static string StringFromColor(Ecouleurs c)
    {
        switch (c)
        {
            case Ecouleurs.ROUGE:
                return String.Format("ROUGE = {0}", (int)c);

            case Ecouleurs.BLEU:
                return String.Format("VERT = {0}", (int)c);

            case Ecouleurs.VERT:
                return String.Format("BLUE = {0}", (int)c);
            case Ecouleurs.JAUNE:
                return String.Format("YELOW = {0}", (int)c);

            default:
                return "Invalid color";
        }
        
    }
}
