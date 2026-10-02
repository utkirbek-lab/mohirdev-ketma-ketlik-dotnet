namespace KetmaKetlik;

// 2. Valyuta konvertori: summa * kurs = so'mdagi summa
public static class Valyuta
{
    public static decimal Konvert(decimal qiymat, decimal kurs) => qiymat / kurs;

    public static void Run()
    {
        decimal qiymat = decimal.Parse(Program.ReadNumber("qiymat="), Program.Inv);
        decimal kurs = decimal.Parse(Program.ReadNumber("kurs (so'm)="), Program.Inv);

        decimal natija = Konvert(qiymat, kurs);

        Console.WriteLine($"{natija.ToString("0.##", Program.Inv)} so'm");
    }
}
