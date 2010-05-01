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
            StringBuilder rezultat = new StringBuilder();
            kreirajOtvoreniTag(rezultat);
            kreirajDecu(rezultat);
            kreirajVrednost(rezultat);
            kreirajZatvoreniTag(rezultat);
            return rezultat.ToString();
        }

        public void kreirajOtvoreniTag(StringBuilder rez)
        {
            rez.Append("\n<");
            rez.Append(ImeTaga);
            rez.Append(">");
        }
        public void kreirajDecu(StringBuilder rez) 
        {
            IEnumerator<XMLCvor> it = Deca.GetEnumerator();
            while (it.MoveNext())
            {
                XMLCvor cvor = (XMLCvor)it.Current;
                //cvor.spajanjeMetoda(rez);
                rez.Append(cvor.ToString());
            }
        }
        public void kreirajVrednost(StringBuilder rez)
        {
            if (Vrednost != "")
                rez.Append(Vrednost);
        }
        public void kreirajZatvoreniTag(StringBuilder rez)
        {
            rez.Append("</");
            rez.Append(ImeTaga);
            rez.Append(">");
        }
        public void spajanjeMetoda(StringBuilder rezultat)
        {
            kreirajOtvoreniTag(rezultat);
            kreirajDecu(rezultat);
            kreirajVrednost(rezultat);
            kreirajZatvoreniTag(rezultat);
        }
    }
}
