using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoHoanHao
{
    internal class inDaySoHoanHao
    {
        public static void inDaySo(int a, int n)    // a: số bắt đầu    ;   n: Dãy n số hoàn hảo
        {
            int dem = 0;
            while(dem < n)
            {
                if(KiemTra.check_soHoanHao(a) == true)
                {
                    Console.Write(a + " ");
                    dem++;
                }
                a++;
            };    
        }
    }
}
