using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Utils
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
    class Info
    { 
        public void ShowInfo()
        {
            Console.WriteLine($"{x}, {y}");
            Console.WriteLine($"{s1}, {s2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            Utils.Swap(ref x, ref y); // x = 2, y = 1

            string s1 = "A", s2 = "B";
            Utils.Swap(ref s1, ref s2); // s1 = "B", s2 = "A"
            Info s = new Info();
            s.ShowInfo();

            Console.ReadKey();
        }
    }
}
