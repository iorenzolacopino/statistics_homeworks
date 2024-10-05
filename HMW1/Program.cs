using System;

namespace HMW1 {
    class Program {
        static bool penetrates(float p){
            return (new Random().Next(0, 100)<(p*100))? true:false;
        }
        static void print(int[] a, int n){
            for (int i=1; i<n+1; i++) Console.WriteLine("Attacker "+i+": "+a[i-1]+" penetrated servers");
        }
        static void Main(string[] args){
            int n;          // number of servers
            int m;          // number of attackers
            float p;        // probability of success
            int[] fd;       // array of frequency distribution
            n=100;
            m=10;
            p=0.7f;
            fd=new int[m];
            int temp;
            for (int i=0; i<m; i++){
                temp=0;
                for (int j=0; j<n; j++) if (penetrates(p)) temp++;
                fd[i]=temp;
            }
            print(fd, m);
        }
    }
}