using DeLaSalle.Practica1.Core.Entities;
using DeLaSalle.Practica1.Core.Managers.Interfaces;
using DeLaSalle.Practica1.Core.Services.Interfaces;

namespace DeLaSalle.Practica1.Core.Managers;

public class ConversorManager : IConversorManager
{
    private readonly IConversorService _service;

    public ConversorManager(IConversorService service)
    {
        _service = service;
    }

    public Conversor GetConversor(Person person)
    {
        return _service.ProcessConversor(person);
    }
}