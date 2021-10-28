using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1714245_TranVanHoang_Lab02_NLLTHDT
{
    class Program
    {
         class PhanSo
        {
            int tuso, mauso;
            public PhanSo(int a, int b)
            {
                tuso = a;
                mauso = b;
            }
            public PhanSo(PhanSo ob)
            {
                tuso = ob.tuso;
                mauso = ob.mauso;
            }
            public void show(){
                Console.WriteLine("Gia tri cua phan so la :{0}/{1}", tuso, mauso);
            }
        }
        static void Main(string[] args)
        {
            PhanSo ob1=new PhanSo(2,5);
            ob1.show();
            PhanSo ob2=new PhanSo(ob1);
            ob2.show();
            Console.ReadLine();
            return;
        }
    }
}
