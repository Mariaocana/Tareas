using System;

namespace Area_perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
              Double l,  ap, result, teta;
            int choice, n;

            Console.Write("Escoja una opcion");
            Console.Write("1. Calcular Perimetro");
            Console.Write("2. Calcular area");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
{
                case 1:
                Console.Write("Ingresar el numero de lados");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingresar la longitud de un solo lado");
                l = Convert.ToDouble(Console.ReadLine());
                result = l * n;
                Console.Write("El Perimetro es : "+ result);
                break;
                case 2:
                Console.Write("Ingresar el numero de lados");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingresar la longitud de un solo lado");
                l = Convert.ToDouble(Console.ReadLine());
                teta = 360 / (2 * n);
                ap = l / (2 * Math.Tan(teta));
                result = (n * l * ap) / 2;
                Console.WriteLine("El Area es : " + result);
                break;
                default:
                Console.Write("Error");
                break;
            }
              Console.ReadKey();
        }
    }
}
