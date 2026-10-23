using System;

class KontoBankowe
{
    private string wlasciciel;
    private decimal saldo;

    public KontoBankowe(string wlasciciel, decimal saldoPoczatkowe)
    {
        this.wlasciciel = wlasciciel;
        saldo = saldoPoczatkowe >= 0 ? saldoPoczatkowe : 0;
    }
    public void PokazInformacje()
    {
        Console.WriteLine($"Właściciel: {wlasciciel} | Aktualne saldo: {saldo} zł");
    }
    public void CzyStacMnie(decimal kwota)
    {
        if (kwota < 0)
        {
            Console.WriteLine($"Podana kwota musi być dodatnia");
        } else
        Console.WriteLine((kwota > saldo) ? false : true);
    }

    public void Wplac(decimal kwota)
    {
        if(kwota <= 0)
        {
            Console.WriteLine("Nieprawidłowa kwota");
            return;
        } 
        saldo += kwota;
        Console.WriteLine($"Wplacono: {kwota} zł");
    }
    public void Wyplac(decimal kwota)
    {
        if(kwota <= 0 || kwota > saldo)
        {
            Console.WriteLine("Nie można wyplacic tej kwoty");
            return;
        } 
        saldo -= kwota;
        Console.WriteLine($"Wyplacono: {kwota} zł");
    }
}
class Program
{
    static void Main()
    {
        KontoBankowe konto1 = new KontoBankowe("Jan", 499);
        KontoBankowe konto2 = new KontoBankowe("Piotr", 2000);
        KontoBankowe konto3 = new KontoBankowe("Adam", 500);

        konto1.CzyStacMnie(500);
        konto1.Wyplac(4000);
        konto3.CzyStacMnie(-100);
        konto2.Wplac(100);
        konto2.Wyplac(2100);
        konto2.PokazInformacje();
    }
}