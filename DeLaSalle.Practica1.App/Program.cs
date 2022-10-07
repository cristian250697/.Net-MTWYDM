using System;
using DeLaSalle.Practica1.Core.Entities;
using DeLaSalle.Practica1.Core.Services;
using DeLaSalle.Practica1.Core.Managers;

namespace DeLaSalle.Practica1.App;

public static class Program
{
    public static void Main (string [] args) 
    {
        float weight = 0;

        System.Console.WriteLine("Enter your Weight in Earth [KG]:");
        Single.TryParse(System.Console.ReadLine(), out weight);

        var person = new Person{Weight = weight};

        var service = new ConversorService();
        var manager = new ConversorManager(service);

        Conversor cnv = manager.GetConversor(person);

        person.WeightOnMars = cnv.WeightOnMars;

        System.Console.WriteLine($"Your weight in Mars is {person.WeightOnMars}");

    }
}