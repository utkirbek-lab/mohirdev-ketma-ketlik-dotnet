using System.Globalization;

namespace KetmaKetlik;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Basic. Ketma-ketlik — 1-amaliy vazifa");
        Console.WriteLine("1 - Doira yuzi va aylana uzunligi");
        Console.WriteLine("2 - Valyuta konvertori");
        Console.WriteLine("3 - Yoshni kunlarda hisoblash");
        Console.Write("Vazifa raqamini tanlang: ");

        switch (Console.ReadLine()?.Trim())
        {
            case "1": Doira.Run(); break;
            case "2": Valyuta.Run(); break;
            case "3": Yosh.Run(); break;
            default: Console.WriteLine("Noto'g'ri tanlov."); break;
        }
    }

    // "4.23" va "4,23" ikkalasini ham qabul qiladi
    internal static string ReadNumber(string prompt)
    {
        Console.Write(prompt);
        return (Console.ReadLine() ?? "0").Trim().Replace(',', '.');
    }

    internal static readonly CultureInfo Inv = CultureInfo.InvariantCulture;
}
