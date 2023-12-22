using PierreFeuilleCiseauxProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierreFeuilleCiseauxUnitTests
{
    [TestClass]
    public class PierreFeuilleCiseauxTests
    {
        [TestMethod]
        public void TestJouerTour()
        {
            // Arrange & Act
            string resultat = PierreFeuilleCiseaux.JouerTour();

            // Assert
            Assert.IsNotNull(resultat);
        }

        [TestMethod]
        public void TestChoisirSymboleAleatoire()
        {
            // Arrange & Act
            string symbole = PierreFeuilleCiseaux.ChoisirSymboleAleatoire();

            // Assert
            CollectionAssert.Contains(new[] { "Pierre", "Feuille", "Ciseaux" }, symbole);
        }

        [TestMethod]
        [DataRow("Pierre", "Ciseaux", "Joueur 1 gagne!")]
        [DataRow("Feuille", "Pierre", "Joueur 1 gagne!")]
        [DataRow("Ciseaux", "Feuille", "Joueur 1 gagne!")]
        [DataRow("Pierre", "Feuille", "Joueur 2 gagne!")]
        [DataRow("Feuille", "Feuille", "Égalité. Rejouez!")]
        public void TestDeterminerResultat(string symboleJoueur1, string symboleJoueur2, string expectedResult)
        {
            // Arrange & Act
            string resultat = PierreFeuilleCiseaux.DeterminerResultat(symboleJoueur1, symboleJoueur2);

            // Assert
            Assert.AreEqual(expectedResult, resultat);
        }
    }
}