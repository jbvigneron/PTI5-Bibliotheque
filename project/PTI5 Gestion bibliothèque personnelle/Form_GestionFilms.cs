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
    public partial class Form_GestionFilms : Form
    {
        public ActionSelectionnee action;
        private int codeCDSelectionne;

        public Form_GestionFilms()
        {
            InitializeComponent();
        }

        // Chargement formulaire
        private void Form_GestionFilms_Load(object sender, EventArgs e)
        {
            if (Mediatheque.RafraichirListeTypeMedias())
            {
                CB_TypeMedia.DataSource = Mediatheque.GetListe();
                ObtenirListeFilms();
            }
        }

        private void ObtenirListeFilms()
        {
            if (Mediatheque.RafraichirListeFilms())
            {
                LB_Films.DataSource = Mediatheque.GetListeMedias();
            }
            else
            {
                MessageBox.Show("Impossible de se connecter à la base de données", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        // Index de la Listbox changé
        private void LB_Films_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_Films.SelectedItem != null)
            {
                AfficherMasquerChamps(false);

                Film itemSelectionne = (Film)LB_Films.SelectedItem; // Récupérer l'item sélectionné
                codeCDSelectionne = itemSelectionne.GetCode(); // Enregistrer le code de l'item sélectionné

                LBL_Infos_Titre.Text = itemSelectionne.GetNom();
                LBL_Infos_DateSortie.Text = "Sortie en " + itemSelectionne.GetAnneeSortie().ToString();
                LBL_Infos_Annee.Text = "Année de sortie: " + itemSelectionne.GetAnneeSortie().ToString();
                LBL_Infos_Support.Text = "Support: " + itemSelectionne.GetType().GetLibelle();
                LBL_Infos_DateAjout.Text = "Album ajouté le " + itemSelectionne.GetDateAjout();

                BTN_Modifier.Enabled = true;
                BTN_Supprimer.Enabled = true;
            }
        }

        // Bouton Ajouter
        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            TXT_Titre.Text = "";
            TXT_AnneeSortie.Text = "";
            TXT_Langue.Text = "Français";
            CB_TypeMedia.SelectedIndex = 0;
            
            action = ActionSelectionnee.Ajouter;
            AfficherMasquerChamps(true);
        }

        // Bouton Modifier
        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            if (LB_Films.SelectedItem != null)
            {
                action = ActionSelectionnee.Modifier;
                AfficherMasquerChamps(true);

                Film itemSelectionne = (Film)LB_Films.SelectedItem;
                Film film = new Film(itemSelectionne.GetCode());

                TXT_Titre.Text = film.GetNom();
                TXT_AnneeSortie.Text = film.GetAnneeSortie().ToString();
                TXT_Langue.Text = film.GetLangue();
                CB_TypeMedia.SelectedIndex = film.GetType().GetCode() - 1;
            }
        }

        // Afficher/Cacher les champs de saisie
        private void AfficherMasquerChamps(bool etat)
        {
            GRB_Champs.Visible = etat;
            LBL_Titre.Visible = etat;
            LBL_Langue.Visible = etat;
            LBL_AnneeSortie.Visible = etat;
            LBL_TypeMedia.Visible = etat;
            CB_TypeMedia.Visible = etat;
            CB_TypeMedia.Visible = etat;
            TXT_Titre.Visible = etat;
            TXT_AnneeSortie.Visible = etat;
            TXT_Langue.Visible = etat;
        }

        // Bouton Supprimer
        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            AfficherMasquerChamps(false);
            
            if(LB_Films.SelectedItem != null)
            {
                if(MessageBox.Show("Voulez-vous vraiment supprimer ce film ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Film itemSelectionne = (Film)LB_Films.SelectedItem; // Récupérer l'item sélectionné
                    Film film = new Film(itemSelectionne.GetCode());
                    film.Supprimer();

                    ObtenirListeFilms();
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
            if(TXT_Titre.Text == "")
            {
                MessageBox.Show("Veuillez indiquer un titre", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_Titre.Focus();
            }
            else if(TXT_Langue.Text == "")
            {
                MessageBox.Show("Veuillez indiquer une langue", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_Langue.Text = "Français";
                TXT_Langue.Focus();
            }
            else if (TXT_AnneeSortie.Text == "")
            {
                MessageBox.Show("Veuillez indiquer une année de sortie", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_AnneeSortie.Focus();
            }
            else
            {
                int anneeParsee;

                Film film = new Film();
                film.SetNom(TXT_Titre.Text);
                film.SetLangue(TXT_Langue.Text);
                film.SetType((TypeMedia)CB_TypeMedia.SelectedItem);

                anneeParsee = int.Parse(TXT_AnneeSortie.Text);
                film.SetAnneeSortie(anneeParsee);

                if (action == ActionSelectionnee.Ajouter)
                {
                    film.Ajouter();
                }
                else if (action == ActionSelectionnee.Modifier)
                {
                    film.SetCode(codeCDSelectionne);
                    film.Modifier();
                }

                AfficherMasquerChamps(false);
                ObtenirListeFilms();
            }
        }

        // Bouton Retour
        private void BTN_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_GestionFilms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mediatheque.ViderListes();
        }
    }
}
