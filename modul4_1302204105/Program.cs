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
            SimpleDataBase<double> basdat = new SimpleDataBase<double>();
            basdat.AddNewData(13);
            basdat.AddNewData(02);
            basdat.AddNewData(20);
            basdat.PrintAllData();
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

    public class SimpleDataBase<T>
    {
        List<T> storedData;
        List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }
        public void AddNewData(T data)
        {
            storedData.Add(data);
            DateTime now = DateTime.Now;
            inputDates.Add(now);
        }
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu " + inputDates[i]);
            }
        }
    }
}