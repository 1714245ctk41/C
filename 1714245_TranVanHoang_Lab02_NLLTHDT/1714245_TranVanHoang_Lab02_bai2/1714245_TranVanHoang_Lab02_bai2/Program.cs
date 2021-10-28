using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1714245_TranVanHoang_Lab02_bai2
{
    class Program
    {
        class myclass
        {
            public static int i;
            public void seti(int n) { i = n; }
            public int geti() { return i; }
        }
        static void Main(string[] args)
        {
            myclass.i=100;
            myclass ob1 = new myclass();
            myclass ob2 = new myclass();
            
            Console.WriteLine("Giá trị ob1: {0}", ob1.geti());
            Console.WriteLine("Giá trị ob2: {0}", ob2.geti());
            Console.ReadLine();
        }
    }
}
/* vì sao giá trị i đối với đối tượng ob2 cũng bằng 10 dù chưa khởi gán giá trị này cho đối tượng ob2?;
khi i được tạo với thành phần của lớp là private static:
-   i trở thành biến toàn cục có phạm vi trong lớp myclass,
tất cả đối tượng của lớp myclass đều có quyền truy cập, chỉnh sửa với if.*/

/*đối với trường hợp public static int i;
 * i được khai báo trong 1 đối tượng, nên có thể được truy cập đến mà không phụ thuộc vào bất kỳ đối tượng nào*/

