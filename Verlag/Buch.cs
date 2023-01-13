using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerlagTests
{
    internal class Buch
    {
        private string autor;
        private string titel;
        private int auflage;

        public Buch(string autorName, string titleName,int auflageName)
        {
            autor = autorName;
            titel = titleName;
            auflage = auflageName;
            e = IndexOutOfRangeException;
        }
        public Buch(string autorName, string titleName)
        {
            autor = autorName;
            titel = titleName;
            auflage = 1;
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        IndexOutOfRangeException e;
        public int Auflage
        {
            get { return auflage; }
            set
            {
                if (auflage <= 0)
                {
                    throw new ArgumentOutOfRangeException("Auflage darf nicht 0 oder kleiner sein", e);
                }
                else
                { 
                    auflage = value; 
                }
            }
        }
        public string Titel
        {
            get { return titel; }

        }
    }
}
