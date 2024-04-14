using RestApp1.Classes;

namespace RestApp1.Services;

public interface IMockDb
{
    public ICollection<Zwierze> GetAll();
    public bool Add(Zwierze zwierze);
    public bool Replace(Zwierze zwierze, int id);

    public Zwierze GetById(int id);

    public bool Remove(int id);
}