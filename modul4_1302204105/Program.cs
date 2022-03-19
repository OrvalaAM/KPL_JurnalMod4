using System;
using System.Collections;
using System.Collections.Generic;

namespace modul4_1302204105
{
    public class Program
    {
        public static void Main()
        {
            Penjumlahan<double> jumlah = new Penjumlahan<double>();
            jumlah.JumlahTigaAngka(13, 02, 20);
        }
    }

    public class Penjumlahan<T>
    {
        public void JumlahTigaAngka(T a, T b, T c)
        {
            dynamic da = a;
            dynamic db = b;
            dynamic dc = c;

            T jumlah = da + db + dc;
            Console.WriteLine(jumlah);
        }
    }
}