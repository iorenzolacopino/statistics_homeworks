using System;

namespace RWalk {
    class Program {
        static int penetrates(float p){
            return (new Random().Next(0, 100)<(p*100))? (1):(-1);
        }
        static void Main(string[] args){
            int n;
            int m;
            float p;
            int[,] dbu;
            int[] fd;
            Console.WriteLine("Number of servers:");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Number of attackers:");
            m=int.Parse(Console.ReadLine());
            Console.WriteLine("Probability of success:");
            p=float.Parse(Console.ReadLine());
            dbu=new int[m, n];
            fd=new int[m];
            for (int i=0; i<m; i++){
                for (int j=0; j<n; j++){
                    if (penetrates(p)==1) dbu[i, j]++;
                    else dbu[i, j]--;
                }
            }
            for (int i=0; i<m; i++)
                for (int j=0; j<n; j++) fd[i]+=dbu[i, j];
            for (int i=0; i<m; i++) Console.WriteLine(fd[i]);
        }
    }
}