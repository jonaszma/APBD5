using RestApp1.Classes;

namespace RestApp1.Services;

    
    
public class MockDb: IMockDb
{
    private ICollection<Zwierze> _zwierzes;

    public MockDb()
    {
        _zwierzes = new List<Zwierze>
        {
            new Zwierze()
            {
                Id = 1,
                Imie = "Puszek",
                KategoriaZwierze = KategoriaZwierze.Kot,
                KolorSiersci = "Biały",
                Masa = 45.6
            },
            new Zwierze()
            {
                Id = 2,
                Imie = "Podmorski Rozrywacz Przyczep",
                KategoriaZwierze = KategoriaZwierze.Pies,
                KolorSiersci = "Krwisty",
                Masa = 145.6
            }

        };
    }

    public ICollection<Zwierze> GetAll()
    {
        return _zwierzes;
    }

    public bool Add(Zwierze zwierze)
    {
        _zwierzes.Add(zwierze);
        return true;
    }

    public bool Replace(Zwierze zwierze, int id)
    {
        var zwierzeToRePlace = _zwierzes.FirstOrDefault(e => e.Id == id);
        if (zwierzeToRePlace is null) return false;
        _zwierzes.Remove(zwierzeToRePlace);
        _zwierzes.Add(zwierze);
        return true;
    }

    public Zwierze GetById(int id)
    {
        var zwierzeToGet = _zwierzes.FirstOrDefault(e => e.Id == id);
        return zwierzeToGet;
    }

    public bool Remove(int id)
    {
        var zwierzeToReRemove = _zwierzes.FirstOrDefault(e => e.Id == id);
        if (zwierzeToReRemove is null) return false;
        _zwierzes.Remove(zwierzeToReRemove);
        return true;
    }
} 