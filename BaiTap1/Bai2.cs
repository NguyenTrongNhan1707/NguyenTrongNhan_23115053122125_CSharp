using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    using System;

    class Bai2
    {
        static void Main()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            if (s == null)
            {
                Console.WriteLine("So tu: 0");
                return;
            }

            s = s.Trim();

            if (s == " ")
            {
                Console.WriteLine("So tu: 0");
                return;
            }

            string[] arr = s.Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);

            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                dem++;
            }

            Console.WriteLine("So tu: " + dem);
        }
    }

}
