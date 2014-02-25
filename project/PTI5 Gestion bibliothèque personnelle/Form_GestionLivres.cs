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
    public partial class Form_GestionLivres : Form
    {
        public ActionSelectionnee action;
        private int codeCDSelectionne;
        
        public Form_GestionLivres()
        {
            InitializeComponent();
        }

        // Chargement formulaire
        private void Form_GestionCD_Load(object sender, EventArgs e)
        {
            ObtenirListeLivres();
        }

        // Lister tous les livres
        private void ObtenirListeLivres()
        {
            if (Mediatheque.RafraichirListeLivres())
            {
                LB_Livres.DataSource = Mediatheque.GetListeMedias();
            }
            else
            {
                MessageBox.Show("Impossible de se connecter à la base de données", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        // Index de la Listbox changé
        private void LB_Livres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_Livres.SelectedItem != null)
            {
                AfficherMasquerChamps(false);

                Livre itemSelectionne = (Livre)LB_Livres.SelectedItem; // Récupérer l'item sélectionné
                codeCDSelectionne = itemSelectionne.GetCode(); // Enregistrer le code de l'item sélectionné

                LBL_Infos_Titre.Text = "Titre: " + itemSelectionne.GetNom();
                LBL_Infos_Auteur.Text = "Ecrit par: " + itemSelectionne.GetAuteur();
                LBL_Infos_NbPages.Text = itemSelectionne.GetNombrePages().ToString() + " pages";
                LBL_Infos_DateAjout.Text = "Livre ajouté le " + itemSelectionne.GetDateAjout();

                BTN_Modifier.Enabled = true;
                BTN_Supprimer.Enabled = true;
            }
        }

        // Bouton Ajouter
        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            TXT_Nom.Text = "";
            TXT_Auteur.Text = "";
            TXT_NbPages.Text = "";
            
            action = ActionSelectionnee.Ajouter;
            AfficherMasquerChamps(true);

            TXT_Nom.Focus();
        }

        // Bouton Modifier
        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            if (LB_Livres.SelectedItem != null)
            {
                action = ActionSelectionnee.Modifier;
                AfficherMasquerChamps(true);

                Livre itemSelectionne = (Livre)LB_Livres.SelectedItem;
                Livre cd = new Livre(itemSelectionne.GetCode());

                TXT_Nom.Text = cd.GetNom();
                TXT_Auteur.Text = cd.GetAuteur();
                TXT_NbPages.Text = cd.GetNombrePages().ToString();

                TXT_Nom.Focus();
            }
        }

        // Afficher/Cacher les champs de saisie
        private void AfficherMasquerChamps(bool etat)
        {
            GRB_Champs.Visible = etat;
            LBL_Nom.Visible = etat;
            LBL_Auteur.Visible = etat;
            LBL_NbPages.Visible = etat;
            TXT_Nom.Visible = etat;
            TXT_Auteur.Visible = etat;
            TXT_NbPages.Visible = etat;
        }

        // Bouton Supprimer
        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            AfficherMasquerChamps(false);
            
            if(LB_Livres.SelectedItem != null)
            {
                if(MessageBox.Show("Voulez-vous vraiment supprimer ce livre ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Livre itemSelectionne = (Livre)LB_Livres.SelectedItem; // Récupérer l'item sélectionné
                    Livre livre = new Livre(itemSelectionne.GetCode());
                    livre.Supprimer();

                    ObtenirListeLivres();
                }
            }
        }

        // Vérifier si l'utilisateur saisie bien des chiffres pour l'année
        private void TXT_AnneeSortie_TextChanged(object sender, EventArgs e)
        {
            int entierTest;
            
            if(int.TryParse(TXT_NbPages.Text, out entierTest) == false)
            {
                TXT_NbPages.Text = "";
            }
        }

        // Bouton validation
        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            if(TXT_Nom.Text == "")
            {
                MessageBox.Show("Veuillez indiquer un titre pour le livre", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_Nom.Focus();
            }
            else if(TXT_Auteur.Text == "")
            {
                MessageBox.Show("Veuillez indiquer un nom d'auteur", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_Auteur.Focus();
            }
            else if (TXT_NbPages.Text == "")
            {
                MessageBox.Show("Veuillez indiquer un nombre de pages", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_NbPages.Focus();
            }
            else
            {
                int nbPagesParsee;

                Livre livre = new Livre();
                livre.SetNom(TXT_Nom.Text);
                livre.SetAuteur(TXT_Auteur.Text);

                nbPagesParsee = int.Parse(TXT_NbPages.Text);
                livre.SetNombrePages(nbPagesParsee);

                if (action == ActionSelectionnee.Ajouter)
                {
                    livre.Ajouter();
                }
                else if (action == ActionSelectionnee.Modifier)
                {
                    livre.SetCode(codeCDSelectionne);
                    livre.Modifier();
                }

                AfficherMasquerChamps(false);
                ObtenirListeLivres();
            }
        }

        // Bouton Retour
        private void BTN_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_GestionLivres_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mediatheque.ViderListes();
        }
    }
}
