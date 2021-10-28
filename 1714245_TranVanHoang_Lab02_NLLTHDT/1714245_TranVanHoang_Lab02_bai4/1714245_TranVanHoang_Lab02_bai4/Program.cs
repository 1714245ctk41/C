using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1714245_TranVanHoang_Lab02_bai4
{
    class Program
    {
        static void Swap(int a, int b)
        {
            int Temp = a;
            a = b;
            b = Temp;
            Console.WriteLine("Trong: a={0}, b={1}", a, b);
        }
        static void Main(string[] args)
        {
            int x = 3, y = 4;
            Console.WriteLine("Truoc: a={0} b={1}", x, y);
            Swap(x, y);
            Console.WriteLine("Sau: a={0}, b={1}", x, y);
            Console.ReadLine();
        }
    }
}
