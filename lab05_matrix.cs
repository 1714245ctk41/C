using System;
using System.Collections.Generic;
using System.Text;
namespace NLLTHDT
{
    class Program
    {
        public class matrix
        {
            int[,] a;
            int r, c;
            public matrix() {
                r = 0;
                c = 0;
                a = new int[r, c];
            }
            public matrix(int row, int col)
            {
                r = row;
                c = col;
                a = new int[row, col];
            }
            public void Nhaphc()
            {
                Console.WriteLine("Nhap hang va cot: ");
                r = Int32.Parse(Console.ReadLine());
                c = Int32.Parse(Console.ReadLine());
            }
            public void nhap()
            {

                a = new int[r, c];
                for(int i=0;i<r;i++)
                {
                    for(int j=0;j<c;j++)
                    {
                        Console.Write("[ {0}, {1} ]", i, j);
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            public void show()
            {
                for (int i = 0; i < r; i++)
                {
                    for(int j=0;j<c;j++)
                    {
                        Console.Write(" {0} ", a[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            public static matrix operator +(matrix mt1, matrix mt2)
            {
                matrix mt = new matrix(mt1.r,mt1.c);
                if (mt1.r != mt2.r || mt1.c != mt2.c) return null;
                else
                {
                    for (int i = 0; i < mt1.r; i++)
                    {
                        for (int j = 0; j < mt1.c; j++)
                        {
                            mt.a[i, j] = mt1.a[i, j] + mt2.a[i, j];
                        }
                    }
                }
                return mt;
            }
            public matrix transpose()
            {
                matrix mt = new matrix(r,c);
                for(int i=0;i<mt.r;i++)
                {
                    for(int j=0;j<mt.c;j++)
                    {
                        mt.a[j, i] = a[i, j];
                    }
                }
                return mt;
            }
            public static matrix operator *(matrix mt1, matrix mt2)
            {
                matrix mt = new matrix(mt1.r, mt1.c);
                for (int i = 0; i < mt1.r; i++)
                    for (int j = 0; j < mt1.c; j++)
                        mt.a[i, j] = mt1.a[i, j] * mt2.a[i, j];
                return mt;
            }
        }
        static void Main(string[] args) 
            {
            matrix kq = new matrix();
            matrix mt1 = new matrix(3,3);
            matrix mt2 = new matrix(3,3);
            Console.WriteLine("Nhap noi dung ma tran: ");
            mt1.nhap();
            mt1.show();
            mt2.nhap();
            mt2.show();
            kq = mt1 + mt2;
            if (kq == null) Console.Write("khong cong duoc");
            else
            {
                Console.WriteLine("tong 2 ma tran: "); kq.show();
            }

            Console.WriteLine("chuyen cot thanh hang, hang thanh cot: ");
            kq=mt1.transpose();
            Console.WriteLine();
            kq.show();
            kq = mt1 * mt2;
            if (kq == null)
                Console.WriteLine("Ma tran rong");
            else
            {
                Console.WriteLine("tich 2 ma tran: ");
                kq.show();
            }
            Console.ReadLine();
            }
    }
}
