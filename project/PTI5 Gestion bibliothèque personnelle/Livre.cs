using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PTI5_Gestion_bibliothèque_personnelle
{
    class Livre : Media
    {
        private string mAuteur;
        private int mNombrePages;

        public Livre()
        {

        }

        public Livre(int code)
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
                requete = "SELECT CODE_ELEMENT, NOM_AUTEUR, NOMBRE_PAGES, NOM_ELEMENT, DATE_AJOUT ";
                requete += "FROM LIVRE ";
                requete += "WHERE CODE_ELEMENT = @CODE";

                mCommande.CommandText = requete;
                mCommande.Parameters.AddWithValue("@CODE", code);

                using(MySqlDataReader mReader = mCommande.ExecuteReader())
                {
                    if (mReader.Read())
                    {
                        mCode = (int)mReader["CODE_ELEMENT"];
                        mAuteur = mReader["NOM_AUTEUR"].ToString();
                        mNombrePages = (int)mReader["NOMBRE_PAGES"];
                        mNom = mReader["NOM_ELEMENT"].ToString();
                        mDateAjout = mReader["DATE_AJOUT"].ToString();
                    }
                }
            }

            mConnexion.Close();
        }
        
        public string GetAuteur()
        {
            return mAuteur;
        }

        public int GetNombrePages()
        {
            return mNombrePages;
        }

        public void SetAuteur(string auteur)
        {
            mAuteur = auteur;
        }

        public void SetNombrePages(int nombrePages)
        {
            if(nombrePages > 0)
            {
                mNombrePages = nombrePages;
            }
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
                requete = "INSERT INTO LIVRE(NOM_AUTEUR, NOMBRE_PAGES, NOM_ELEMENT, DATE_AJOUT) ";
                requete += "VALUES (@NOM_AUTEUR, @NOMBRE_PAGES, @NOM_ELEMENT, @DATE_AJOUT)";

                mCommande.CommandText = requete;
                mCommande.Parameters.AddWithValue("@NOM_AUTEUR", mAuteur);
                mCommande.Parameters.AddWithValue("@NOMBRE_PAGES", mNombrePages);
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
                requete = "UPDATE LIVRE ";
                requete += "SET NOM_AUTEUR = @NOM_AUTEUR, ";
                requete += "NOMBRE_PAGES = @NOMBRE_PAGES, ";
                requete += "NOM_ELEMENT = @NOM_ELEMENT ";
                requete += "WHERE CODE_ELEMENT = @CODE";

                mCommande.CommandText = requete;
                mCommande.Parameters.AddWithValue("@NOM_AUTEUR", mAuteur);
                mCommande.Parameters.AddWithValue("@NOMBRE_PAGES", mNombrePages);
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
                requete = "DELETE FROM LIVRE WHERE CODE_ELEMENT = @CODE";

                mCommande.CommandText = requete;
                mCommande.Parameters.AddWithValue("@CODE", mCode);
                mCommande.ExecuteNonQuery();
            }

            mConnexion.Close();
        }

        public override string ToString()
        {
            return mNom + ", " + mAuteur;
        }
    }
}
