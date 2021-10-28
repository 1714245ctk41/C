using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1714245_TranVanHoang_Lab02_Bai6
{
    class Program
    {
        class PhanSo
        {
            int tuso;
            int mauso;

            public PhanSo()
            {
            }
            public PhanSo(int t, int m)
            {
                tuso = t;
                mauso = m;
            }
            public PhanSo(PhanSo ps)
            {
                tuso = ps.tuso;
                mauso = ps.mauso;
            }

            public void Show()
            {
                Console.WriteLine("{0}/{1}", tuso, mauso);
            }

            public PhanSo Cong(PhanSo ps)
            {
                PhanSo kq = new PhanSo();
                kq.tuso = tuso * ps.mauso + mauso * ps.tuso;
                kq.mauso = mauso * ps.mauso;
                return kq;
            }
            public PhanSo Tru(PhanSo ps)
            {
                PhanSo kq = new PhanSo();
                kq.tuso = tuso * ps.mauso - mauso * ps.tuso;
                kq.mauso = mauso * ps.mauso;
                return kq;
            }
            public PhanSo Nhan(PhanSo ps)
            {
                PhanSo kq = new PhanSo();
                kq.tuso = tuso * ps.tuso;
                kq.mauso = mauso * ps.mauso;
                return kq;
            }
            public PhanSo Chia(PhanSo ps)
            {
                PhanSo kq = new PhanSo();
                kq.tuso = tuso * ps.mauso;
                kq.mauso = mauso * ps.tuso;
                return kq;
            }
            public void show(){
                Console.WriteLine("{0}/{1}", tuso,mauso);
            }
        }
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo(1, 2);
            PhanSo ps2 = new PhanSo(2, 3);
            PhanSo kq;
            kq=ps1.Cong(ps2);
            kq.show();
           
            kq = ps1.Tru(ps2);
            kq.show();
            kq = ps1.Nhan(ps2);
            kq.show();
            kq = ps1.Chia(ps2);
            kq.show();
            Console.ReadLine();
        }
    }
}
