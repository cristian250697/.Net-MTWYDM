using DeLaSalle.Practica1.Core.Services.Interfaces;
using DeLaSalle.Practica1.Core.Entities;

namespace DeLaSalle.Practica1.Core.Services;

public class ConversorService : IConversorService
{
    public Conversor ProcessConversor(Person person)
    {
        var cnv = new Conversor();

        cnv.WeightOnMars = (person.Weight / 9.81f) * 3.711f;

        return cnv;
    }
}