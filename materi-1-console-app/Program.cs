using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dengan_Visual_C
{

    class Program
    {

        static void Main(string[] args)
        {
            int angka1;
            int angka2;
            int hasil;

            angka1 = 10;
            angka2 = 5;


            hasil = angka1 + angka2;
            Console.WriteLine("hasil dari penjumlahan" + angka1.ToString() + "dan" + angka2.ToString() + "adalah" + hasil.ToString());
            Console.ReadKey();
        }
    }
}

