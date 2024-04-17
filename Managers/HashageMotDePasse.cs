using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Mots_Merveilles.Managers
{
    /// <summary>
    /// Classe de sécurisation des mots de passe
    /// </summary>
    public class HashageMotDePasse
    {
        /// <summary>
        /// Salage et hachage d'un mot de passe
        /// </summary>
        /// <param name="motDePasse"></param>
        /// <returns>Mot de passe haché</returns>
        public static string HasherMotDePasse(string motDePasse, string sel)
        {
            byte[] selBytes = Convert.FromBase64String(sel);

            // Conversion du mot de passe en tableau de bytes
            byte[] motDePasseBytes = Encoding.UTF8.GetBytes(motDePasse);

            // Concaténation du sel avec le mot de passe
            byte[] motDePasseAvecSel = new byte[selBytes.Length + motDePasseBytes.Length];
            Buffer.BlockCopy(selBytes, 0, motDePasseAvecSel, 0, selBytes.Length);
            Buffer.BlockCopy(motDePasseBytes, 0, motDePasseAvecSel, selBytes.Length, motDePasseBytes.Length);

            // Hachage du mot de passe avec le sel
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] motDePasseHacheBytes = sha256.ComputeHash(motDePasseAvecSel);
                string motDePasseHache = Convert.ToBase64String(motDePasseHacheBytes);
                return (motDePasseHache);
            }
        }

        /// <summary>
        /// Vérification du mot de passe
        /// </summary>
        /// <param name="motDePasse"></param>
        /// <param name="motDePasseHache"></param>
        /// <param name="sel"></param>
        /// <returns>Vrai si le mot de passe correspond</returns>
        public static bool VerifierMotDePasse(string motDePasse, string motDePasseHache, string sel)
        {
            // Convertir le mot de passe fourni en tableau de bytes
            byte[] motDePasseBytes = Encoding.UTF8.GetBytes(motDePasse);

            // Décoder le sel et le mot de passe haché de Base64
            byte[] selBytes = Convert.FromBase64String(sel);
            byte[] motDePasseHacheBytes = Convert.FromBase64String(motDePasseHache);

            // Concaténer le sel avec le mot de passe fourni
            byte[] motDePasseAvecSel = new byte[selBytes.Length + motDePasseBytes.Length];
            Buffer.BlockCopy(selBytes, 0, motDePasseAvecSel, 0, selBytes.Length);
            Buffer.BlockCopy(motDePasseBytes, 0, motDePasseAvecSel, selBytes.Length, motDePasseBytes.Length);

            // Calculer le haché du mot de passe fourni avec le sel
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] motDePasseHacheCalculeBytes = sha256.ComputeHash(motDePasseAvecSel);
                return StructuralComparisons.StructuralEqualityComparer.Equals(motDePasseHacheBytes, motDePasseHacheCalculeBytes);
            }
        }

        /// <summary>
        /// Generer un sel aléatoire
        /// </summary>
        /// <returns>Sel généré</returns>
        public static byte[] GenererSel()
        {
            // Générer un sel aléatoire
            byte[] sel = new byte[32];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(sel);
            }
            return sel;
        }
    }
}
