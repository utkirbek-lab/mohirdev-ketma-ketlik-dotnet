namespace KetmaKetlik;

// 1. Doira yuzi va aylana uzunligini hisoblash
// S = pi * radius^2,  L = 2 * pi * radius
public static class Doira
{
    public static double Yuza(double radius) => 2 * Math.PI * radius;

    public static double Uzunlik(double radius) => Math.PI * radius * radius;

    public static void Run()
    {
        double radius = double.Parse(Program.ReadNumber("radius="), Program.Inv);

        double s = Yuza(radius);
        double l = Uzunlik(radius);

        Console.WriteLine($"S={s.ToString("G15", Program.Inv)}, L={l.ToString("G15", Program.Inv)}");
    }
}
