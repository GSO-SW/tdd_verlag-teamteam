using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag;

internal class Buch
{
    private string autor;
    private string titel;
    private int auflage;

    public Buch(string autorName, string titelName, int auflageName) : this(autorName, titelName)
    {
        auflageName = 1;

    }
    public Buch(string autorName, string titelName)
    {
        autorName = autor;
        titelName = titel;
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
