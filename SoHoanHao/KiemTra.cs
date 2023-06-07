using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoHoanHao
{
    internal class KiemTra
    {
        public static bool check_soHoanHao(int a)
        {
            if(a <= 5) return false;
            int sum = 1;
            for(int i = 2; i < a; i++)
            {
                if (a % i == 0) sum += i;
            }

            return (sum == a)? true : false;
        }
    }
}
