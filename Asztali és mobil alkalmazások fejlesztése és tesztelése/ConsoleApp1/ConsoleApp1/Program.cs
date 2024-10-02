using System;

abstract class Csomag
{
    public double Suly { get; set; }
    public string Felado { get; set; }
    public string Cimzett { get; set; }

    public Csomag(double suly, string felado, string cimzett)
    {
        Suly = suly;
        Felado = felado;
        Cimzett = cimzett;
    }

    public abstract double SzallitasiKoltseg();
}

class LevelCsomag : Csomag
{
    public LevelCsomag(double suly, string felado, string cimzett)
        : base(suly, felado, cimzett) { }

    public override double SzallitasiKoltseg()
    {
        return Suly * 50; 
    }
}

class TorekenyCsomag : Csomag
{
    public double ExtraVedekezesiKoltseg { get; set; }

    public TorekenyCsomag(double suly, string felado, string cimzett, double extraVedekezesiKoltseg)
        : base(suly, felado, cimzett)
    {
        ExtraVedekezesiKoltseg = extraVedekezesiKoltseg;
    }

    public override double SzallitasiKoltseg()
    {
        return (Suly * 100) + ExtraVedekezesiKoltseg; 
    }
}

class Program
{
    static void Main(string[] args)
    {

        LevelCsomag levelCsomag = new LevelCsomag(2.5, "Kiss János", "Nagy Péter");
        Console.WriteLine($"Levélcsomag szállítási költsége: {levelCsomag.SzallitasiKoltseg()} Ft");

        TorekenyCsomag torekenyCsomag = new TorekenyCsomag(3.0, "Kovács Anna", "Szabó Béla", 200);
        Console.WriteLine($"Törékeny csomag szállítási költsége: {torekenyCsomag.SzallitasiKoltseg()} Ft");
    }
}
