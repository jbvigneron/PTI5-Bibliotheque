using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.ComponentModel;

namespace PTI5_Gestion_bibliothèque_personnelle
{
    abstract class Media
    {
        protected int mCode;
        protected string mNom;
        protected string mDateAjout;

        public int GetCode()
        {
            return mCode;
        }

        public string GetNom()
        {
            return mNom;
        }

        public string GetDateAjout()
        {
            return mDateAjout.Substring(0, 10);
        }

        public void SetCode(int code)
        {
            mCode = code;
        }

        public void SetNom(string nom)
        {
            mNom = nom;
        }

        public override string ToString()
        {
            return mNom;
        }
    }
}