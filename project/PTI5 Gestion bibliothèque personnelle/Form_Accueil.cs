using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PTI5_Gestion_bibliothèque_personnelle
{
    public partial class Form_Accueil : Form
    {
        public Form_Accueil()
        {
            InitializeComponent();
        }

        private void Form_Accueil_Load(object sender, EventArgs e)
        {
            string serveur = "127.0.0.1";
            string database = "bibliotheque";
            string login = "root";
            string password = "";

            Program.ConnectionString = "server=" + serveur + "; Initial Catalog=" + database + ";User Id=" + login + ";Password=" + password;
        }

        private void BTN_Livres_Click(object sender, EventArgs e)
        {
            Form_GestionLivres f = new Form_GestionLivres();
            f.ShowDialog();
        }

        private void BTN_CD_Click(object sender, EventArgs e)
        {
            Form_GestionCDAudio f = new Form_GestionCDAudio();
            f.ShowDialog();
        }

        private void BTN_Films_Click(object sender, EventArgs e)
        {
            Form_GestionFilms f = new Form_GestionFilms();
            f.ShowDialog();
        }

        private void BTN_Livres_MouseEnter(object sender, EventArgs e)
        {
            LBL_Livres.Visible = true;
        }

        private void BTN_CD_MouseEnter(object sender, EventArgs e)
        {
            LBL_CD.Visible = true;
        }

        private void BTN_Films_MouseEnter(object sender, EventArgs e)
        {
            LBL_Films.Visible = true;
        }

        private void BTN_Livres_MouseLeave(object sender, EventArgs e)
        {
            LBL_Livres.Visible = false;
        }

        private void BTN_CD_MouseLeave(object sender, EventArgs e)
        {
            LBL_CD.Visible = false;
        }

        private void BTN_Films_MouseLeave(object sender, EventArgs e)
        {
            LBL_Films.Visible = false;
        }
    }
}
