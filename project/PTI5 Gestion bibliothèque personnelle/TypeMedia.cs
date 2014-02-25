using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PTI5_Gestion_bibliothèque_personnelle
{
    class TypeMedia
    {
        private int mCode;
        private string mLibelle;
        
        public TypeMedia()
        {

        }

        public TypeMedia(int code)
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
                requete = "SELECT CODE_TYPE, LIBELLE_TYPE ";
                requete += "FROM TYPEMEDIA ";
                requete += "WHERE CODE_TYPE = @CODE";

                mCommande.CommandText = requete;
                mCommande.Parameters.AddWithValue("@CODE", code);

                using (MySqlDataReader mReader = mCommande.ExecuteReader())
                {
                    if (mReader.Read())
                    {
                        mCode = (int)mReader["CODE_TYPE"];
                        mLibelle = mReader["LIBELLE_TYPE"].ToString();
                    }
                }
            }

            mConnexion.Close();
        }

        public int GetCode()
        {
            return mCode;
        }

        public string GetLibelle()
        {
            return mLibelle;
        }

        public override string ToString()
        {
            return mLibelle;
        }
    }
}
