using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300107
{
    class PemrosesData
    {
        public void DapatkanNilaiTerbesar<T>(T angka1,T angka2,T angka3) {

            dynamic a1 = angka1;
            dynamic a2 = angka2;
            dynamic a3 = angka3;

                if(a1 > a2 && a1 > a3)
            {
                Console.WriteLine("angka tebersar"+" "+a1);
            }
            if (a2 > a1 && a2 > a3)
            {
                Console.WriteLine("angka tebersar" + " " + a2);
            }
            if (a3 > a2 && a3 > a1)
            {
                Console.WriteLine("angka tebersar" + " " + a3);
            }
        }
        static void Main(String[] args)
        {
            PemrosesData max = new PemrosesData();
            int nim1 = 10;
            int nim2 = 30;
            int nim3 = 20;
            max.DapatkanNilaiTerbesar(nim1, nim2, nim3);
        }
    }
}
