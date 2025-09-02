using System;
using Models;


class Program
{
    static void Main(string[] args)
    {
        var bob = new Personne { Nom = "Bob" };
        var roboto = new Chien { Nom = "Roboto" };
        var mitaine = new Chat { Nom = "Mitaine" };

        bob.Animaux.Add(roboto);
        bob.Animaux.Add(mitaine);

        bob.Travailler(8); // Bob travaille 8 heures
        Console.WriteLine($"Compte de {bob.Nom} après le travail: { bob.Compte} $");

        bob.NourrirAnimaux(); // Nourrir les animaux

        bob.NourrirAnimaux(); // Essayer de nourrir à nouveau
    }
}