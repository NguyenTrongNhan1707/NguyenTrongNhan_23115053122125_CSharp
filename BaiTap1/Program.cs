using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class BaiTapDauTien
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ho ten sinh vien: ");
            String Hotensv = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Hotensv))
            {
                Console.WriteLine("Loi do rong hoac null");
                return;
            }
            Hotensv = Hotensv.Trim();
            string[] arr = Hotensv.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string ketQua = "";

            for (int i = 0; i < arr.Length; i++)
            {
                string tu = arr[i];

                string tuChuanHoa =
                    char.ToUpper(tu[0]) + tu.Substring(1).ToLower();

                ketQua += tuChuanHoa + " ";
            }

            Console.WriteLine("Ho ten sinh vien sau khi chuan hoa: " + ketQua.Trim());
            Console.ReadKey(); // Dừng màn hình
        }
        
    }
}
