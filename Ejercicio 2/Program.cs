using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de minutos:");
            int totalMinutos = Convert.ToInt32(Console.ReadLine());

            int horas = totalMinutos / 60;
            int minutos = totalMinutos % 60;

            Console.WriteLine($"{totalMinutos} minutos son {horas} horas y {minutos} minutos.");
        }
    }
}
