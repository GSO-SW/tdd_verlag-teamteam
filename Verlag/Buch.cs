using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verlag;
namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string buchtitel;
        private int auflage;

        public Buch(string autorName, string titleName,int auflageNummer)
        {
            autor = autorName;
            buchtitel = titleName;
            auflage = auflageNummer;
        }
        public Buch(string autorName, string titleName)
        {
            autor = autorName;
            buchtitel = titleName;
            auflage = 1;
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int Auflage
        {
            get { return auflage; }
            set
            {
                if (auflage <= 0)
                {
                    throw new ArgumentOutOfRangeException("Auflage darf nicht 0 oder kleiner sein");
                }
                else
                { 
                    auflage = value; 
                }
            }
        }
        public string Titel
        {
            get { return buchtitel; }

        }
    }
}
