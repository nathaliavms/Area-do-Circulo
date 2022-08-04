using System;
using System.Globalization;

namespace Desafio_Data_04082022
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio;
            double n = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = n * (raio * raio);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}
