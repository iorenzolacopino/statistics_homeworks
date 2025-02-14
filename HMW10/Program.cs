using System;

namespace HMW10;

class Program
{
    static double Function(double x)
    {
        return x * x;                        // example function: f(x) = x^2
    }

    // computing Reimann integral with trapezoidal rule
    static double RiemannIntegral(double a, double b, int n)
    {
        double sum = 0;
        double dx = (b - a) / n;
        for (int i = 0; i < n; i++)
        {
            double x1 = a + i * dx;
            double x2 = x1 + dx;
            sum += (Function(x1) + Function(x2)) / 2 * dx;
        }
        return sum;
    }

    static double LebesgueIntegral(double a, double b, int m)
    {
        int n = m * 10;                     // domain points
        double[] xVals = Enumerable.Range(0, n).Select(i => a + (b - a) * i / (n - 1)).ToArray();
        double[] fVals = xVals.Select(Function).ToArray();
        double fMin = fVals.Min();
        double fMax = fVals.Max();
        double dy = (fMax - fMin) / m;
        double sum = 0;
        for (int j = 0; j < m; j++)
        {
            double y1 = fMin + j * dy;
            double y2 = y1 + dy;
            double measure = xVals.Count(x => Function(x) >= y1 && Function(x) < y2) / (double)n * (b - a);
            sum += measure * (y1 + y2) / 2;
        }
        return sum;
    }

    static void Main()
    {
        double a, b;                                                                // Integration interval
        int n;                                                                      // Number of partitions for Riemann integral
        int m;                                                                      // Number of partitions for Lebesgue integral
        Console.WriteLine("Minimum interval:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("\nMaximum interval:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("\nNumber of partitions for Riemann integral");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("\nNumber of partitions for Lebesgue integral");
        m = int.Parse(Console.ReadLine());
        double riemannResult = RiemannIntegral(a, b, n);
        double lebesgueResult = LebesgueIntegral(a, b, m);
        Console.WriteLine($"\n\nRiemann Integral: " + riemannResult);
        Console.WriteLine($"Lebesgue Integral: " + lebesgueResult + "\n");
    }
}