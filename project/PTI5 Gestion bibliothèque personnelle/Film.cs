using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PTI5_Gestion_bibliothèque_personnelle
{
    class Film : Media
    {
        private TypeMedia mType;
        private int mAnneeSortie;
        private string mLangue;

        public Film()
        {
            mType = new TypeMedia();
        }

        public Film(int code)
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
                requete = "SELECT CODE_ELEMENT, CODE_TYPE, ANNEE_SORTIE, LANGUE, NOM_ELEMENT, DATE_AJOUT ";
                requete += "FROM FILM ";
                requete += "WHERE CODE_ELEMENT = @CODE";

                mCommande.CommandText = requete;
                mCommande.Parameters.AddWithValue("@CODE", code);

                using (MySqlDataReader mReader = mCommande.ExecuteReader())
                {
                    if (mReader.Read())
                    {
                        mCode = (int)mReader["CODE_ELEMENT"];
                        mType = new TypeMedia((int)mReader["CODE_TYPE"]);
                        mAnneeSortie = (int)mReader["ANNEE_SORTIE"];
                        mLangue = mReader["LANGUE"].ToString();
                        mNom = mReader["NOM_ELEMENT"].ToString();
                        mDateAjout = mReader["DATE_AJOUT"].ToString();
                    }
                }
            }

            mConnexion.Close();
        }

        // Du fait qu'il existe déjà une autre méthode appelée GetType() par défaut, on utilise new pour la redéfinir
        public new TypeMedia GetType()
        {
            return mType;
        }

        public int GetAnneeSortie()
        {
            return mAnneeSortie;
        }

        public string GetLangue()
        {
            return mLangue;
        }

        public void SetType(TypeMedia type)
        {
            mType = type;
        }

        public void SetAnneeSortie(int anneeSortie)
        {
            mAnneeSortie = anneeSortie;
        }

        public void SetLangue(string langue)
        {
            mLangue = langue;
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
                requete = "INSERT INTO FILM(CODE_TYPE, ANNEE_SORTIE, LANGUE, NOM_ELEMENT, DATE_AJOUT) ";
                requete += "VALUES (@CODE_TYPE, @ANNEE_SORTIE, @LANGUE, @NOM_ELEMENT, @DATE_AJOUT)";

                mCommande.CommandText = requete;
                mCommande.Parameters.AddWithValue("@CODE_TYPE", mType.GetCode());
                mCommande.Parameters.AddWithValue("@ANNEE_SORTIE", mAnneeSortie);
                mCommande.Parameters.AddWithValue("@LANGUE", mLangue);
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
                requete = "UPDATE FILM ";
                requete += "SET CODE_TYPE = @CODE_TYPE, ";
                requete += "ANNEE_SORTIE = @ANNEE_SORTIE, ";
                requete += "LANGUE = @LANGUE, ";
                requete += "NOM_ELEMENT = @NOM_ELEMENT ";
                requete += "WHERE CODE_ELEMENT = @CODE";

                mCommande.CommandText = requete;
                mCommande.Parameters.AddWithValue("@CODE_TYPE", mType.GetCode());
                mCommande.Parameters.AddWithValue("@ANNEE_SORTIE", mAnneeSortie);
                mCommande.Parameters.AddWithValue("@LANGUE", mLangue);
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
                requete = "DELETE FROM FILM WHERE CODE_ELEMENT = @CODE";

                mCommande.CommandText = requete;
                mCommande.Parameters.AddWithValue("@CODE", mCode);
                mCommande.ExecuteNonQuery();
            }

            mConnexion.Close();
        }
    }
}
