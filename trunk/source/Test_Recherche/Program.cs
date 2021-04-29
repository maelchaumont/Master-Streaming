﻿using Class;
using System;
using System.Collections.Generic;

namespace Test_Recherche
{
    class Program
    {
        static void Main(string[] args)
        {
            var ensemble = new Dictionary<Genre, List<Oeuvre>>();

            var l1 = new List<Oeuvre>()
            {
                new Serie("Elite",new DateTime(2019,10,1),"Série mêlant Drame et Amour","////",3),
                new Serie("La casa de papel",DateTime.Now,"Série mêlant Drame et Action","////",3),
                new Serie("La petite maison dans la prairie",new DateTime(2000,02,20),"Pas vraiement une série","////",0)
            };

            var l2 = new List<Oeuvre>()
            {
                new Serie("Elite",new DateTime(2019,10,1),"Série mêlant Drame et Amour","////",3),
                new Serie("Une série",DateTime.Now,"Série mêlant Drame et Action","////",3),
                new Serie("Bonne une série",new DateTime(2000,02,20),"Pas vraiment une série","////",0)
            };

            ensemble.Add(new Genre("Drame"), l1);
            ensemble.Add(new Genre("Amour"), l2);

            Console.WriteLine("Affichage Dictionary \n\n");

            foreach(var listing in ensemble)
            {
                Console.WriteLine($"Key :{listing.Key} ");
                foreach(Oeuvre oeuvre in listing.Value)
                {
                    Console.WriteLine($" Value : {oeuvre}");
                }
            }

            Console.WriteLine("\n\nRecherche d'Oeuvres\n");

            var MaRecherche = ensemble.RechercherOeuvres("elite");
            foreach (Oeuvre o in MaRecherche)
            {
                Console.WriteLine(o);
            }
            //Console.WriteLine(l1.Contains(new Serie("Elite", new DateTime(2019, 10, 1), "Série mêlant Drame et Amour", "////", 3)));

            //Console.WriteLine("\n");
            //Console.WriteLine("jean".StartsWith("jea"));
        }
    }
}