using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<string> arrlist = new List<string>(5);
            arrlist.Add("Nguyễn");
            arrlist.Add("Thành");
            arrlist.Add("Tân");
            arrlist.Add("Tồ");
            Console.WriteLine("list ban đầu: ");
            Console.WriteLine("số lượng phần tử list trong mảng : {0}", arrlist.Count);
            foreach (var item in arrlist)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("==============================================");

            /// chèn vào vị trí thứ 3 thành chữ đẹp trai
            arrlist.Insert(3, "HandSome");
            Console.WriteLine("list lúc sau là : ");
            Console.WriteLine("số lượng phần tử list trong mảng : {0}",arrlist.Count);
            foreach (var item in arrlist)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("==============================================");

            /// xem phần tử của list có tồn tại trong list
            Console.WriteLine("xin mời nhập một từ gì đó trong dãy");
            string userPush = Console.ReadLine();
            bool Exists = arrlist.Contains(userPush);
            if(Exists == false)
            {
                Console.WriteLine("ko có từ bạn nhập trong list");
            }
            Console.WriteLine("==============================================");

            /// copy to sang mảng 1 chiều
            string[] arr1 = new string[arrlist.Count];
            arrlist.CopyTo(arr1, 0);
            Console.WriteLine("xuất các phần tử trong mảng tương ứng với list");
            foreach (string caigithenay in arr1)
            {
                Console.WriteLine(caigithenay);
            }
            Console.WriteLine("==============================================");


            /// trả về chỉ sô index của từ cần tìm
            Console.WriteLine("trả về chỉ sô index của từ cần tìm");
            Console.WriteLine(arrlist.IndexOf("Thành"));
            Console.WriteLine("==============================================");

            /// Đảo ngược list trong danh sách
            arrlist.Reverse();
            foreach (string sothututronglist in arrlist)
            {
                Console.Write(sothututronglist+" ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
