namespace RestApp1.Classes;

public class Zwierze
{
    public int Id { get; set; }
    public string Imie { get; set; }
    public KategoriaZwierze KategoriaZwierze { get; set; }
    public double Masa { get; set; }
    public string KolorSiersci { get; set; }
}