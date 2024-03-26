using Mots_Merveilles.Forms;

namespace Mots_Merveilles
{
    internal static class Program
    {
        /// <summary>
        ///  Programme principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Accueil());
        }
    }
}