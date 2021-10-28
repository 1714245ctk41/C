using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1714245_TranVanHoang_lab02_Bai5
{
    class Program
    {
        public class Time
        {
            private int Hour;
            private int Minute;
            private int Second;
            public void Display()
            {
                Console.WriteLine("{0}:{1}:{2}", Hour, Minute, Second);
            }
            public void GetTime(ref int h, ref int m, ref int s)
            {
                h = Hour;
                m = Minute;
                s = Second;
            }
            public Time(System.DateTime dt)
            {
                Hour = dt.Hour;
                Minute = dt.Minute;
                Second = dt.Second;
            }
        }
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Time t = new Time(currentTime);
            t.Display();
            int theHour=0 ;
            int theMinute=0 ;
            int theSecond=0 ;
            t.GetTime(ref theHour, ref theMinute, ref theSecond);
            Console.WriteLine("Current time:{0}:{1}:{2}", theHour, theMinute, theSecond);
            Console.ReadLine();
        }
    }
}
/*khi sử dụng từ khóa out 
 ref: trước khi dùng phải gán giá trị.
 * out: không cần gán giá trị trước khi dùng.
 */