using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Klase;
namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLCvor cd = new XMLCvor();
            cd.ImeTaga = "CD";
            cd.Vrednost = "\n";
            
            XMLCvor naziv = new XMLCvor(); 
            naziv.ImeTaga = "NAZIV";
            naziv.Vrednost = "Californication";
            
            XMLCvor bend = new XMLCvor();
            bend.ImeTaga = "BEND";
            bend.Vrednost = "RHCP";
            
            XMLCvor zemlja = new XMLCvor();
            zemlja.ImeTaga = "ZEMLJA";
            zemlja.Vrednost = "USA";
            
            XMLCvor godina = new XMLCvor();
            godina.ImeTaga = "GODINA";
            godina.Vrednost = "1999";

            cd.Deca.Add(naziv);
            cd.Deca.Add(bend);
            cd.Deca.Add(zemlja);
            cd.Deca.Add(godina);

            Console.WriteLine(cd.ToString());

        }
    }
}
