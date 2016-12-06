using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pilihan;
            Console.WriteLine("Masukkan unit asal yang akan dikonversikan:\n 1. Celcius \n 2. Reamur \n 3. Fahrenheit");
            Pilihan = int.Parse(Console.ReadLine());
            switch(Pilihan)
            {
                case 1:
                    double C1, R1, F1, K1;
                    Console.WriteLine("Masukkan nilai Celcius: ");
                    C1 = double.Parse(Console.ReadLine());
                    R1 = C1 * 4 / 5;
                    F1 = (C1 + 32) * 9 / 5;
                    K1 = C1 + 273.15;
                    Console.WriteLine("{0} Celcius sama dengan {1} Reamur, {2} Fahrenheit, dan {3} Kelvin", C1, R1, F1, K1);
                    break;

                case 2:
                    double R2, C2, F2, K2;
                    Console.WriteLine("Masukkan nilai Reamur: ");
                    R2 = double.Parse(Console.ReadLine());
                    C2 = R2 * 5 / 4;
                    F2 = (C2 + 32) * 9 / 5;
                    K2 = C2 + 273.15;
                    Console.WriteLine("{0} Reamur sama dengan {1} Celcius, {2} Fahrenheit, dan {3} Kelvin", R2, C2, F2, K2);
                    break;

                case 3:
                    double F3, C3, R3, K3;
                    Console.WriteLine("Masukkan nilai Fahrenheit: ");
                    F3 = double.Parse(Console.ReadLine());
                    C3 = (F3 - 32) * 5 / 9;
                    R3 = C3 * 4 / 5;
                    K3 = C3 + 273.15;
                    Console.WriteLine("{0} Fahrenheit sama dengan {1} Celcius, {2} Reamur, dan {3} Kelvin", F3, C3, R3, K3);
                    break;
            }
            Console.ReadLine();
        }
    }
}
