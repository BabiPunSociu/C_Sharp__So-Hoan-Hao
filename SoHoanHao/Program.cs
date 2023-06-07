using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoHoanHao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.Write("Nhap x (x>0): x = ");
                x = Convert.ToInt32(Console.ReadLine());
            } while (x <= 0);

            Console.WriteLine("x = " + x + " có phải là sô hoàn hảo?\t" + KiemTra.check_soHoanHao(x));

            Console.WriteLine();

            Console.Write("Dãy gồm 20 số hoàn hảo bắt đầu từ 0 là:\t");
            inDaySoHoanHao.inDaySo(0, 20);
        }
    }
}
