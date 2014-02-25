using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PTI5_Gestion_bibliothèque_personnelle
{
    public partial class Form_GestionCDAudio : Form
    {
        public ActionSelectionnee action;
        private int codeCDSelectionne;

        public Form_GestionCDAudio()
        {
            InitializeComponent();
        }

        // Chargement formulaire
        private void Form_GestionCD_Load(object sender, EventArgs e)
        {
            ObtenirListeCDs();
        }

        private void ObtenirListeCDs()
        {
            if (Mediatheque.RafraichirListeCDAudio())
            {
                LB_CDs.DataSource = Mediatheque.GetListeMedias();
            }
            else
            {
                MessageBox.Show("Impossible de se connecter à la base de données", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        // Index de la Listbox changé
        private void LB_CDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_CDs.SelectedItem != null)
            {
                AfficherMasquerChamps(false);

                CDAudio itemSelectionne = (CDAudio)LB_CDs.SelectedItem; // Récupérer l'item sélectionné
                codeCDSelectionne = itemSelectionne.GetCode(); // Enregistrer le code de l'item sélectionné

                LBL_Infos_Album.Text = "Album: " + itemSelectionne.GetNom();
                LBL_Infos_Artiste.Text = "Artiste: " + itemSelectionne.GetArtiste();
                LBL_Infos_AnneeSortie.Text = "Année de sortie: " + itemSelectionne.GetAnneeSortie().ToString();
                LBL_Infos_DateAjout.Text = "Album ajouté le " + itemSelectionne.GetDateAjout();

                BTN_Modifier.Enabled = true;
                BTN_Supprimer.Enabled = true;
            }
        }

        // Bouton Ajouter
        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            TXT_Album.Text = "";
            TXT_Artiste.Text = "";
            TXT_AnneeSortie.Text = "";
            
            action = ActionSelectionnee.Ajouter;
            AfficherMasquerChamps(true);

            TXT_Album.Focus();
        }

        // Bouton Modifier
        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            if (LB_CDs.SelectedItem != null)
            {
                action = ActionSelectionnee.Modifier;
                AfficherMasquerChamps(true);

                CDAudio itemSelectionne = (CDAudio)LB_CDs.SelectedItem;
                CDAudio cd = new CDAudio(itemSelectionne.GetCode());

                TXT_Album.Text = cd.GetNom();
                TXT_Artiste.Text = cd.GetArtiste();
                TXT_AnneeSortie.Text = cd.GetAnneeSortie().ToString();

                TXT_Album.Focus();
            }
        }

        // Afficher/Cacher les champs de saisie
        private void AfficherMasquerChamps(bool etat)
        {
            GRB_Champs.Visible = etat;
            LBL_Album.Visible = etat;
            LBL_Artiste.Visible = etat;
            LBL_AnneeSortie.Visible = etat;
            TXT_Album.Visible = etat;
            TXT_Artiste.Visible = etat;
            TXT_AnneeSortie.Visible = etat;
        }

        // Bouton Supprimer
        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            AfficherMasquerChamps(false);
            
            if(LB_CDs.SelectedItem != null)
            {
                if(MessageBox.Show("Voulez-vous vraiment supprimer ce CD ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CDAudio itemSelectionne = (CDAudio)LB_CDs.SelectedItem; // Récupérer l'item sélectionné
                    CDAudio cd = new CDAudio(itemSelectionne.GetCode());
                    cd.Supprimer();

                    ObtenirListeCDs();
                }
            }
        }

        // Vérifier si l'utilisateur saisie bien des chiffres pour l'année
        private void TXT_AnneeSortie_TextChanged(object sender, EventArgs e)
        {
            int entierTest;
            
            if(int.TryParse(TXT_AnneeSortie.Text, out entierTest) == false)
            {
                TXT_AnneeSortie.Text = "";
            }
        }

        // Bouton validation
        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            if(TXT_Album.Text == "")
            {
                MessageBox.Show("Veuillez indiquer un nom d'album", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_Album.Focus();
            }
            else if(TXT_Artiste.Text == "")
            {
                MessageBox.Show("Veuillez indiquer un nom d'artiste", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_Artiste.Focus();
            }
            else if (TXT_AnneeSortie.Text == "")
            {
                MessageBox.Show("Veuillez indiquer une date de sortie", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_AnneeSortie.Focus();
            }
            else
            {
                int anneeParsee;

                CDAudio cd = new CDAudio();
                cd.SetAlbum(TXT_Album.Text);
                cd.SetArtiste(TXT_Artiste.Text);

                anneeParsee = int.Parse(TXT_AnneeSortie.Text);
                cd.SetAnneeSortie(anneeParsee);

                if (action == ActionSelectionnee.Ajouter)
                {
                    cd.Ajouter();
                }
                else if (action == ActionSelectionnee.Modifier)
                {
                    cd.SetCode(codeCDSelectionne);
                    cd.Modifier();
                }

                AfficherMasquerChamps(false);
                ObtenirListeCDs();
            }
        }

        // Bouton Retour
        private void BTN_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_GestionCDAudio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mediatheque.ViderListes();
        }
    }
}
