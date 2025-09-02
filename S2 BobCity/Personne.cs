using System;
using System.Collections.Generic;
using Models;

public class Personne
{
    public string Nom { get; set; }
    public decimal Compte { get; private set; }
    public List<Animal> Animaux { get; } = new();

    public void Travailler(float heures)
    {
        Compte += (decimal)heures * 22.50m;
    }

    public void NourrirAnimaux()
    {
        foreach (var animal in Animaux)
        {
            if (animal.EstAffame() && Compte >= animal.coutRepas)
            {
                Compte -= animal.coutRepas;
                animal.Manger();
                Console.WriteLine($"{ animal.Nom} a mangé.");
            }
            else if (animal.EstAffame() && Compte < animal.coutRepas)
            {
                Console.WriteLine($"Compte insuffisant pour nourrir ${ animal.Nom} .");
            }
            else
            {
                Console.WriteLine($"{ animal.Nom} n'a pas faim.");

        }
    }
}
}

