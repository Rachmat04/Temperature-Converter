using System;

namespace Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan unit asal yang akan dikonversikan:\n 1. Celcius \n 2. Reamur \n 3. Fahrenheit");
            int pilihan = int.Parse(Console.ReadLine());

            switch(pilihan)
            {
                case 1:
                    Console.WriteLine("Masukkan nilai Celcius: ");
                    double celcius = double.Parse(Console.ReadLine());
                    KonversiCelcius(celcius);
                    break;

                case 2:
                    Console.WriteLine("Masukkan nilai Reamur: ");
                    double reamur = double.Parse(Console.ReadLine());
                    KonversiReamur(reamur);
                    break;

                case 3:
                    Console.WriteLine("Masukkan nilai Fahrenheit: ");
                    double fahrenheit = double.Parse(Console.ReadLine());
                    KonversiFahrenheit(fahrenheit);
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
            Console.ReadLine();
        }

        // Fungsi konversi dari Celcius ke unit lain
        static void KonversiCelcius(double celsius)
        {
            double reamur = celsius * 4 / 5;
            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;
            Console.WriteLine("{0} Celcius sama dengan {1} Reamur, {2} Fahrenheit, dan {3} Kelvin", celsius, reamur, fahrenheit, kelvin);
        }

        // Fungsi konversi dari Reamur ke unit lain
        static void KonversiReamur(double reamur)
        {
            double celsius = reamur * 5 / 4;
            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;
            Console.WriteLine("{0} Reamur sama dengan {1} Celcius, {2} Fahrenheit, dan {3} Kelvin", reamur, celsius, fahrenheit, kelvin);
        }

        // Fungsi konversi dari Fahrenheit ke unit lain
        static void KonversiFahrenheit(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            double reamur = celsius * 4 / 5;
            double kelvin = celsius + 273.15;
            Console.WriteLine("{0} Fahrenheit sama dengan {1} Celcius, {2} Reamur, dan {3} Kelvin", fahrenheit, celsius, reamur, kelvin);
        }
    }
}
