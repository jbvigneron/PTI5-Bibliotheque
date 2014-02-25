using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PTI5_Gestion_bibliothèque_personnelle
{
    class Mediatheque
    {
        static List<Media> mListeMedias = new List<Media>();
        static List<TypeMedia> mListeTypeMedias = new List<TypeMedia>();

        static public bool RafraichirListeLivres()
        {
            MySqlConnection mConnexion = new MySqlConnection(Program.ConnectionString);

            try
            {
                mConnexion.Open();
            }
            catch
            {
                return false;
            }

            using (MySqlCommand mCommande = mConnexion.CreateCommand())
            {
                string requete;
                requete = "SELECT CODE_ELEMENT ";
                requete += "FROM LIVRE ";
                requete += "ORDER BY NOM_AUTEUR";

                mCommande.CommandText = requete;

                using (MySqlDataReader mReader = mCommande.ExecuteReader())
                {
                    while (mReader.Read())
                    {
                        Livre livre = new Livre((int)mReader["CODE_ELEMENT"]);
                        mListeMedias.Add(livre);
                    }
                }
            }

            mConnexion.Close();
            return true;
        }

        static public bool RafraichirListeCDAudio()
        {
            MySqlConnection mConnexion = new MySqlConnection(Program.ConnectionString);

            try
            {
                mConnexion.Open();
            }
            catch
            {
                return false;
            }

            using (MySqlCommand mCommande = mConnexion.CreateCommand())
            {
                string requete;
                requete = "SELECT CODE_ELEMENT ";
                requete += "FROM CD ";
                requete += "ORDER BY NOM_ARTISTE, ANNEE_SORTIE DESC";

                mCommande.CommandText = requete;

                using (MySqlDataReader mReader = mCommande.ExecuteReader())
                {
                    while (mReader.Read())
                    {
                        CDAudio cd = new CDAudio((int)mReader["CODE_ELEMENT"]);
                        mListeMedias.Add(cd);
                    }
                }
            }

            mConnexion.Close();
            return true;
        }

        static public bool RafraichirListeFilms()
        {
            MySqlConnection mConnexion = new MySqlConnection(Program.ConnectionString);

            try
            {
                mConnexion.Open();
            }
            catch
            {
                return false;
            }

            using (MySqlCommand mCommande = mConnexion.CreateCommand())
            {
                string requete;
                requete = "SELECT CODE_ELEMENT ";
                requete += "FROM FILM ";
                requete += "ORDER BY NOM_ELEMENT";

                mCommande.CommandText = requete;

                using (MySqlDataReader mReader = mCommande.ExecuteReader())
                {
                    while (mReader.Read())
                    {
                        Film film = new Film((int)mReader["CODE_ELEMENT"]);
                        mListeMedias.Add(film);
                    }
                }
            }

            mConnexion.Close();
            return true;
        }

        static public List<Media> GetListeMedias()
        {
            return mListeMedias;
        }

        static public bool RafraichirListeTypeMedias()
        {
            MySqlConnection mConnexion = new MySqlConnection(Program.ConnectionString);

            try
            {
                mConnexion.Open();
            }
            catch
            {
                return false;
            }

            using (MySqlCommand mCommande = mConnexion.CreateCommand())
            {
                string requete;
                requete = "SELECT CODE_TYPE ";
                requete += "FROM TYPEMEDIA ";

                mCommande.CommandText = requete;

                using (MySqlDataReader mReader = mCommande.ExecuteReader())
                {
                    while (mReader.Read())
                    {
                        TypeMedia typeMedia = new TypeMedia((int)mReader["CODE_TYPE"]);
                        mListeTypeMedias.Add(typeMedia);
                    }
                }
            }

            mConnexion.Close();
            return true;
        }

        static public List<TypeMedia> GetListe()
        {
            return mListeTypeMedias;
        }

        static public void ViderListes()
        {
            mListeMedias.Clear();
            mListeTypeMedias.Clear();
        }
    }
}
