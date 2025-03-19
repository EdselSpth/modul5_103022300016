using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace modul5_103022300016
{
    class PemrosesData
    {
        public void DapatkanNilaiTerbesar<T>(T a, T b, T c)
        {
            // penggunaan variable sementara bertipe data dynamic untuk konfigurasi semua tipe data

            dynamic A = (dynamic)a;
            dynamic B = (dynamic)b;
            dynamic C = (dynamic)c;

            if (A > B && A > C)
            {
                Console.WriteLine("Nilai terbesar adalah " + a);
            }
            else if (B > A && B > C)
            {
                Console.WriteLine("Nilai terbesar adalah " + b);
            }
            else
            {
                Console.WriteLine("Nilai terbesar adalah " + c);
            }
        }
    }
}

