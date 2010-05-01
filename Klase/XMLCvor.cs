using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klase
{
    public class XMLCvor
    {
        private string imeTaga;
        private string vrednost;
        private char[] prazan = new char[0];
        private List<XMLCvor> deca = new List<XMLCvor>();

        public List<XMLCvor> Deca
        {
            get { return deca; }
            set { deca = value; }
        }
        
        public string ImeTaga
        {
            get { return imeTaga; }
            set { imeTaga = value; }
        }

        public string Vrednost
        {
            get { return vrednost; }
            set { vrednost = value; }
        }

        public override string ToString()
        {
            string rezultat = new string(prazan);
            rezultat += "<" + ImeTaga + ">";

            IEnumerator<XMLCvor> it = Deca.GetEnumerator();
            while (it.MoveNext())
            {
                XMLCvor cvor = (XMLCvor)it.Current;
                rezultat += "\n" + cvor.ToString();
            }
            if (Vrednost != "")
                rezultat += Vrednost;
            rezultat += "</" + ImeTaga + ">";
            return rezultat;
        }
    }
}
