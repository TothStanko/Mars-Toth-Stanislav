using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Mars
{
    class Program
    {
        static void Keres(List<Bolygok> b)
        {
            Console.Write("Írd be a keresett bolygó nevét:");
            string valasz=string.Empty;


            if (valasz == "Plútó")
            {
                Console.WriteLine("Sajnos nincs ilyen nevű bolygó a naprendszerbe");
            }


        }

        static void Main(string[] args)
        {
            List<Bolygok> bolygo = new List<Bolygok>();

            foreach (var item in File.ReadAllLines(@"../../../src/solsys.txt"))
            {
                bolygo.Add(new Bolygok(item));
            }

            foreach (var item in bolygo)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\n3.1: Feladat");

            double db = 0;

            for (int i = 0; i < bolygo.Count; i++)
            {
                db++;

            }

            Console.WriteLine($"{db} bolygó van a naprendszerben");


            Console.WriteLine("\n3.2:Feladat");

            double atlag = 0;

            atlag = bolygo.Average(b => b.Holdszam);

            Console.WriteLine($"a naprendszerben egy bolygónak átlagosan {atlag} holdja van");


            Console.WriteLine("\n3.3.:Feladat");

            Console.WriteLine("\n3.4.:Feladat");

            Keres(bolygo);


            Console.ReadLine();
        }
    }
}
