using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PTI5_Gestion_bibliothèque_personnelle
{
    class CDAudio : Media
    {
        private string mArtiste;
        private int mAnneeSortie;

        public CDAudio()
        {

        }

        public CDAudio(int code)
        {
            MySqlConnection mConnexion = new MySqlConnection();
            mConnexion.ConnectionString = Program.ConnectionString;

            try
            {
                mConnexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlCommand mCommande = mConnexion.CreateCommand())
            {
                string requete;
                requete = "SELECT CODE_ELEMENT, NOM_ARTISTE, ANNEE_SORTIE, NOM_ELEMENT, DATE_AJOUT ";
                requete += "FROM CD ";
                requete += "WHERE CODE_ELEMENT = @CODE";

                mCommande.CommandText = requete;
                mCommande.Parameters.AddWithValue("@CODE", code);

                using(MySqlDataReader mReader = mCommande.ExecuteReader())
                {
                    if (mReader.Read())
                    {
                        mCode = (int)mReader["CODE_ELEMENT"];
                        mNom = mReader["NOM_ELEMENT"].ToString();
                        mArtiste = mReader["NOM_ARTISTE"].ToString();
                        mAnneeSortie = (int)mReader["ANNEE_SORTIE"];
                        mDateAjout = mReader["DATE_AJOUT"].ToString();
                    }
                }
            }

            mConnexion.Close();
        }

        public string GetArtiste()
        {
            return mArtiste;
        }

        public int GetAnneeSortie()
        {
            return mAnneeSortie;
        }

        public void SetArtiste(string artiste)
        {
            mArtiste = artiste;
        }

        public void SetAlbum(string album)
        {
            mNom = album;
        }

        public void SetAnneeSortie(int anneeSortie)
        {
            mAnneeSortie = anneeSortie;
        }

        public void Ajouter()
        {
            MySqlConnection mConnexion = new MySqlConnection();
            mConnexion.ConnectionString = Program.ConnectionString;

            try
            {
                mConnexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlCommand mCommande = mConnexion.CreateCommand())
            {
                string requete;
                requete = "INSERT INTO CD(NOM_ARTISTE, ANNEE_SORTIE, NOM_ELEMENT, DATE_AJOUT) ";
                requete += "VALUES (@NOM_ARTISTE, @ANNEE_SORTIE, @NOM_ELEMENT, @DATE_AJOUT)";

                mCommande.CommandText = requete;
                mCommande.Parameters.AddWithValue("@NOM_ARTISTE", mArtiste);
                mCommande.Parameters.AddWithValue("@ANNEE_SORTIE", mAnneeSortie);
                mCommande.Parameters.AddWithValue("@NOM_ELEMENT", mNom);
                mCommande.Parameters.AddWithValue("@DATE_AJOUT", DateTime.Today);
                mCommande.ExecuteNonQuery();
            }
        }

        public void Modifier()
        {
            MySqlConnection mConnexion = new MySqlConnection();
            mConnexion.ConnectionString = Program.ConnectionString;

            try
            {
                mConnexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlCommand mCommande = mConnexion.CreateCommand())
            {
                string requete;
                requete = "UPDATE CD ";
                requete += "SET NOM_ARTISTE = @NOM_ARTISTE, ";
                requete += "ANNEE_SORTIE = @ANNEE_SORTIE, ";
                requete += "NOM_ELEMENT = @NOM_ELEMENT ";
                requete += "WHERE CODE_ELEMENT = @CODE";

                mCommande.CommandText = requete;
                mCommande.Parameters.AddWithValue("@NOM_ARTISTE", mArtiste);
                mCommande.Parameters.AddWithValue("@ANNEE_SORTIE", mAnneeSortie);
                mCommande.Parameters.AddWithValue("@NOM_ELEMENT", mNom);
                mCommande.Parameters.AddWithValue("@CODE", mCode);
                mCommande.ExecuteNonQuery();
                
            }

            mConnexion.Close();
        }

        public void Supprimer()
        {
            MySqlConnection mConnexion = new MySqlConnection();
            mConnexion.ConnectionString = Program.ConnectionString;

            try
            {
                mConnexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlCommand mCommande = mConnexion.CreateCommand())
            {
                string requete;
                requete = "DELETE FROM CD WHERE CODE_ELEMENT = @CODE";

                mCommande.CommandText = requete;
                mCommande.Parameters.AddWithValue("@CODE", mCode);
                mCommande.ExecuteNonQuery();
            }

            mConnexion.Close();
        }

        public override string ToString()
        {
            return mArtiste + " -" + mNom;
        }
    }
}
