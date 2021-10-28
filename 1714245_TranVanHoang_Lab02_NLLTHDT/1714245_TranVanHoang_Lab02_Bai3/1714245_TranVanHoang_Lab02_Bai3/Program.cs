using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1714245_TranVanHoang_Lab02_Bai3
{
    class Program
    {
        class TienIch
        {
            
            public static int LuyThua(int a, int n)
            {
                int kq=1;
                for (int i = 1; i <= n; i++)
                    kq *= a;
                return kq;
            }
            public static int USCLN(int a, int b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
                while(a!=b)
                {
                    if (a > b)
                        a = a - b;
                    if (a < b)
                        b = b - a;
                }
                return a;
            }
            
            public static int BSCNN(int a, int b)
            {
                return (a * b) / USCLN(a, b);
            }
            
        }
        static void Main(string[] args)
        {

            int kq;
            kq = TienIch.LuyThua(2, 3);
            Console.WriteLine("luy thua :{0}",kq);
            
             kq=TienIch.USCLN(2, 3);
             Console.WriteLine("USCLN:{0}", kq);
             kq = TienIch.BSCNN(5, 2);
             Console.WriteLine("BSCNN:{0}", kq);
             Console.ReadLine();
        }
    }
}
