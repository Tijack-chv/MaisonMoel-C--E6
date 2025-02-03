using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Maison_moel.Model
{
    public class TestValidation
    {
    // Vérifie si l'email est valide
        public static bool EstEmailValide(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        // Vérifie si le mot de passe est sécurisé
        public static bool EstMotDePasseValide(string mdp)
        {
            if (mdp.Length < 8)
                return false;

            // Vérifie si le mot de passe contient au moins une majuscule, une minuscule, un chiffre et un caractère spécial
            bool contientMajuscule = Regex.IsMatch(mdp, @"[A-Z]");
            bool contientMinuscule = Regex.IsMatch(mdp, @"[a-z]");
            bool contientChiffre = Regex.IsMatch(mdp, @"\d");
            bool contientSpecial = Regex.IsMatch(mdp, @"[\W_]"); // \W correspond aux caractères non alphanumériques

            return contientMajuscule && contientMinuscule && contientChiffre && contientSpecial;
        }

        public static bool EstAgeValide(DateTime dateNaissance)
        {
            // Calculer la date minimale requise
            DateTime dateActuelle = DateTime.Today;
            DateTime dateMinimale = dateActuelle.AddYears(-16);

            // Vérifier si la date de naissance est avant ou égale à la date minimale
            return dateNaissance <= dateMinimale;
        }
    }
}

