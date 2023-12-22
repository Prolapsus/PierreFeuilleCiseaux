using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierreFeuilleCiseauxProject
{
    public class PierreFeuilleCiseaux
    {
        private static readonly List<string> Symboles = new List<string> { "Pierre", "Feuille", "Ciseaux" };

        public static string JouerTour()
        {
            string choixJoueur1 = ChoisirSymboleAleatoire();
            string choixJoueur2 = ChoisirSymboleAleatoire();

            Console.WriteLine($"Joueur 1 choisit: {choixJoueur1}");
            Console.WriteLine($"Joueur 2 choisit: {choixJoueur2}");

            string resultat = DeterminerResultat(choixJoueur1, choixJoueur2);

            Console.WriteLine($"Résultat: {resultat}");
            Console.WriteLine();

            return resultat;
        }

        public static string ChoisirSymboleAleatoire()
        {
            Random random = new Random();
            int index = random.Next(Symboles.Count);
            return Symboles[index];
        }

        public static string DeterminerResultat(string symboleJoueur1, string symboleJoueur2)
        {
            if (symboleJoueur1 == symboleJoueur2)
            {
                return "Égalité. Rejouez!";
            }
            else if ((symboleJoueur1 == "Pierre" && symboleJoueur2 == "Ciseaux") ||
                     (symboleJoueur1 == "Feuille" && symboleJoueur2 == "Pierre") ||
                     (symboleJoueur1 == "Ciseaux" && symboleJoueur2 == "Feuille"))
            {
                return "Joueur 1 gagne!";
            }
            else
            {
                return "Joueur 2 gagne!";
            }
        }
    }
}