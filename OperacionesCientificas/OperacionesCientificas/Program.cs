using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCientificas
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;
            float resultado;
            int opcion;
            string respuesta;

            do
            {

                Console.WriteLine("ingrese un numero");
                num = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("1 valor Absoluto");
                Console.WriteLine("2 Potenciacion");
                Console.WriteLine("3 raiz cuadrada");
                Console.WriteLine("4 seno");
                Console.WriteLine("5 coseno");
                Console.WriteLine("6 Numero maximo");
                Console.WriteLine("7 Numero minimo");
                Console.WriteLine("8 parte entera");
                Console.WriteLine("9 redondeo");

                Console.WriteLine("ESCOGE UNA OPCION");
                opcion = Convert.ToInt32(Console.ReadLine());



                switch (opcion)
                {
                    case 1:

                        resultado = Math.Abs(num);
                        Console.WriteLine("el valor absoluto es {0}", resultado);
                        break;

                    case 2:

                        Console.WriteLine("potencia:" + Math.Pow(num, 3));
                        break;
                    case 3:

                        Console.WriteLine("reiz cuadrada:" + Math.Sqrt(num));
                        break;
                    case 4:

                        Console.WriteLine("seno" + Math.Sin(num * Math.PI / 180));
                        break;
                    case 5:

                        Console.WriteLine("Coseno" + Math.Cos(num * Math.PI / 180));
                        break;
                    case 6:

                        Console.WriteLine("numero max:" + Math.Max(num, 100));
                        break;
                    case 7:

                        Console.WriteLine("numero min" + Math.Min(num, 100));
                        break;
                    case 8:

                        Console.WriteLine("parte entera:" + Math.Truncate(num));

                        break;
                    case 9:

                        Console.WriteLine("redondeando:" + Math.Round(num));

                        break;

                    default:

                        Console.WriteLine("opcion invalida");
                        break;

                }

                Console.WriteLine("desea otra operacion ? SI/NO");
                respuesta = Console.ReadLine();

            } while (respuesta == "SI");

                      
            
            Console.WriteLine("pulse una tecla para salir");
            Console.ReadKey();

        }



        /* Console.WriteLine("el valor absoluto es {0}", resultado);
         Console.WriteLine("potencia:" + Math.Pow(num, 3));
         Console.WriteLine("reiz cuadrada:" + Math.Sqrt(num));
         Console.WriteLine("seno" + Math.Sin(num * Math.PI / 180));
         Console.WriteLine("numero max:" + Math.Max(num, 50));
         Console.WriteLine("numero min" + Math.Min(num, 50));
         Console.WriteLine("parte entera:" + Math.Truncate(num));
         Console.WriteLine("redondeando:" + Math.Round(num));
         */



    }

 }


