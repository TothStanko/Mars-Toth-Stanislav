using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars
{
    class Bolygok
    {
        public string Nev { get; set; }
        public int Holdszam { get; set; }
        public double BolygoTerfogat { get; set; }

        public Bolygok(string sor)
        {
            List<string> atmeneti = sor.Split(';').ToList();

            Nev = atmeneti[0];
            Holdszam = Convert.ToInt32(atmeneti[1]);
            BolygoTerfogat =Convert.ToDouble( atmeneti[2]);
        }

        public override string ToString()
        {
            return $"Bolygó neve: {Nev} | Holdak száam: {Holdszam} || Bolygó térfogata: {BolygoTerfogat}";
        }


    }
}
