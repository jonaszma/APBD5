using RestApp1.Classes;

namespace RestApp1.Services;

public interface IMockWz
{
    public bool Add(Wizyta wizyta);
    public ICollection<Wizyta> GetByZwierzeId(int id);
}