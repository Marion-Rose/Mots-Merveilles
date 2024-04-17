using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mots_Merveilles.Managers
{
    /// <summary>
    /// Classe permettant de contrôler les entrées de l'utilisateur
    /// </summary>
    public class ControleEntree
    {
        /// <summary>
        /// Méthode permettant de formater un texte en nom propre
        /// </summary>
        /// <param name="entree"></param>
        /// <returns>Nom propre</returns>
        public static string FormaterTexteNom(string entree)
        {
            if (string.IsNullOrEmpty(entree))
            {
                return entree;
            }
            return char.ToUpper(entree[0]) + entree.Substring(1).ToLower();
        }

        /// <summary>
        /// Méthode permettant de formater un texte de prix pour uniformiser la virgule
        /// </summary>
        /// <param name="entree"></param>
        /// <returns>Prix sous forme de texte avec virgule</returns>
        public static string FormaterTextePrix(string entree)
        {
            if (string.IsNullOrEmpty(entree))
            {
                return entree;
            }
            return entree.Replace(".", ",");
        }

        /// <summary>
        /// Méthode permettant de vérifier les texte de type nom
        /// </summary>
        /// <param name="entree"></param>
        /// <returns>Vrai si le texte est conforme</returns>
        public static bool VerifierTexteNom(string entree)
        {
            //séquence d'un ou plusieurs caractères alphabétiques, apostrophes, espaces ou tirets
            Regex regex = new Regex("^[a-zA-Z'\\s-]*$");
            return regex.IsMatch(entree);
        }

        /// <summary>
        /// Méthode permettant de vérifier les texte de type e-mail
        /// </summary>
        /// <param name="entree"></param>
        /// <returns>Vrai si l'adresse est conforme</returns>
        public static bool VerifierTexteMail(string entree)
        {
            //séquence d'un ou plusieurs caractères alphanumériques, points ou tirets + @ + séquence d'un ou plusieurs caractères alphanumériques ou tirets + point + séquence de 2 ou 3 caractères alphanumériques
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(entree);
        }

        /// <summary>
        /// Méthode permettant de vérifier les texte de type téléphone
        /// </summary>
        /// <param name="entree"></param>
        /// <returns>Vrai si le téléphone est conforme</returns>
        public static bool VerifierTexteTelephone(string entree)
        {
            //séquence de 10 chiffres
            Regex regex = new Regex(@"^[0-9]{10}$");
            return regex.IsMatch(entree);
        }

        /// <summary>
        /// Méthode permettant de vérifier les texte de type prix
        /// </summary>
        /// <param name="entree"></param>
        /// <returns>Vrai si le prix est conforme</returns>
        public static bool VerifierTextePrix(string entree)
        {
            //séquence de chiffres, point et virgule
            Regex regex = new Regex(@"^[0-9\.,]+$");
            return regex.IsMatch(entree);
        }

        /// <summary>
        /// Méthode permettant de vérifier les texte de type quantité
        /// </summary>
        /// <param name="entree"></param>
        /// <returns>Vrai si la quantité est conforme</returns>
        public static bool VerifierTexteQuantite(string entree)
        {
            //séquence de chiffres
            Regex regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(entree);
        }

        /// <summary>
        /// Méthode permettant de vérifier les texte de type ISBN
        /// </summary>
        /// <param name="entree"></param>
        /// <returns>Vrai si l'ISBN est conforme</returns>
        public static bool VerifierIsbn(string entree)
        {
            //séquence de 13 chiffres
            Regex regex = new Regex(@"^[0-9]{13}$");
            return regex.IsMatch(entree);
        }

        /// <summary>
        /// Méthode permettant de vérifier les texte de type code postal
        /// </summary>
        /// <param name="entree"></param>
        /// <returns>Vrai si le code postal est conforme</returns>
        public static bool VerifierCodePostal(string entree)
        {
            //séquence de 5 chiffres
            Regex regex = new Regex(@"^[0-9]{5}$");
            return regex.IsMatch(entree);
        }
    }
}
