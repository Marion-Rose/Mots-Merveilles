using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mots_Merveilles.Managers
{
    public class ControleEntree
    {
        public static string FormaterTexteNom(string entree)
        {
            if (string.IsNullOrEmpty(entree))
            {
                return entree;
            }
            return char.ToUpper(entree[0]) + entree.Substring(1).ToLower();
        }

        public static string FormaterTextePrix(string entree)
        {
            if (string.IsNullOrEmpty(entree))
            {
                return entree;
            }
            return entree.Replace(".", ",");
        }

        public static bool VerifierTexteNom(string entree)
        {
            //séquence d'un ou plusieurs caractères alphabétiques, apostrophes, espaces ou tirets
            Regex regex = new Regex("^[a-zA-Z'\\s-]*$");
            return regex.IsMatch(entree);
        }

        public static bool VerifierTexteMail(string entree)
        {
            //séquence d'un ou plusieurs caractères alphanumériques, points ou tirets + @ + séquence d'un ou plusieurs caractères alphanumériques ou tirets + point + séquence de 2 ou 3 caractères alphanumériques
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(entree);
        }

        public static bool VerifierTexteTelephone(string entree)
        {
            //séquence de 10 chiffres
            Regex regex = new Regex(@"^[0-9]{10}$");
            return regex.IsMatch(entree);
        }

        public static bool VerifierTextePrix(string entree)
        {
            //séquence de chiffres, point et virgule
            Regex regex = new Regex(@"^[0-9\.,]+$");
            return regex.IsMatch(entree);
        }

        public static bool VerifierTexteQuantite(string entree)
        {
            //séquence de chiffres
            Regex regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(entree);
        }

        public static bool VerifierIsbn(string entree)
        {
            //séquence de 13 chiffres
            Regex regex = new Regex(@"^[0-9]{13}$");
            return regex.IsMatch(entree);
        }

        public static bool VerifierCodePostal(string entree)
        {
            //séquence de 5 chiffres
            Regex regex = new Regex(@"^[0-9]{5}$");
            return regex.IsMatch(entree);
        }
    }
}
