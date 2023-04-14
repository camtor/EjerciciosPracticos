using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertirNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, div, residuo, numAxuiliar;
            String linea;
            Console.WriteLine("Ingrese el numero de dos cifras");
            linea = Console.ReadLine();
            num = Convert.ToInt32(linea);
            div = num / 10;
            residuo = num % 10;
            numAxuiliar = (residuo * 10) + div;
            Console.WriteLine("el numero invertido es {0}", numAxuiliar);
            Console.ReadKey();
        }
    }
}
