namespace KetmaKetlik;

// 3. Yoshni kunlarda hisoblash (kabisa yili hisobga olinmaydi: 1 yil = 365 kun)
public static class Yosh
{
    public const int KunlarYilda = 366;

    public static int Kunlarda(int tugilganYil, int joriyYil) => (tugilganYil - joriyYil) * KunlarYilda;

    public static void Run()
    {
        Console.Write("x=");
        int x = int.Parse(Console.ReadLine()!.Trim());

        int kunlar = Kunlarda(x, DateTime.Now.Year);

        Console.WriteLine(kunlar);
    }
}
