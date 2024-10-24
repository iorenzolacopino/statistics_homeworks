using System;

namespace HMW4;

public class Program{

    private static bool penetrates(double p){
        return new Random().Next(0, 100) < (p * 100)? true : false;
    }

    static void Main(string[] args){
        int t, n;
        double p, v = 0.0;
        Console.WriteLine("t: ");
        t = int.Parse(Console.ReadLine());
        Console.WriteLine("n: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("p: ");
        p = double.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++){
            if (penetrates(p)) v += Math.Sqrt(1.0 / (float)n);
            else v -= Math.Sqrt(1.0 / (float)n);
        }
        Console.WriteLine(v.ToString());
    }
}