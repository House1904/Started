using System;

class Program
{
    static double TinhHieu(double a, double b)
    {
        return a - b;
    }

    static void Main()
    {
        double x, y;
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        double Hieu = TinhHieu(x, y);

        Console.WriteLine($"Hieu cua {x} va {y} là: {Hieu}");
    }
}
