using System;

namespace Num_pares
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int num;
            Console.WriteLine("Ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("El numero ingresado es par");

            }
            else
            {
                Console.WriteLine("El numero ingresado no es par");
            }
            Console.ReadKey();
        }
    }
}
