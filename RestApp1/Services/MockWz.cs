using RestApp1.Classes;

namespace RestApp1.Services;

public class MockWz : IMockWz
{
    private ICollection<Wizyta> _wizytas;

    public MockWz()
    {
        _wizytas = new List<Wizyta>
        {
        new Wizyta()
        {
            Cena = 120,
            DataWizyty = DateTime.Now,
            Opis = "slodki",
            Zwierze = new Zwierze()
            {
                Id=11,
                Imie = "Kubuś",
                KategoriaZwierze = 0,
                KolorSiersci = "zolty",
                Masa = 120
            }
        }    
        };
    }
    
    
    
    public bool Add(Wizyta wizyta)
    {
        _wizytas.Add(wizyta);
        return true;
    }

    public ICollection<Wizyta> GetByZwierzeId(int id)
    {
        ICollection < Wizyta > ListaZwierzaka= new List<Wizyta>();
        foreach (var wizyta in _wizytas)
        {
            if (wizyta.Zwierze.Id==id)
            {
                ListaZwierzaka.Add(wizyta);
            }
        }

        return ListaZwierzaka;
    }
}