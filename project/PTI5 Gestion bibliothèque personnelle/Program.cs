using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PTI5_Gestion_bibliothèque_personnelle
{
    static class Program
    {
        public static string ConnectionString { get; set; }

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Accueil());
        }
    }

    public enum ActionSelectionnee { Ajouter, Modifier };
}
