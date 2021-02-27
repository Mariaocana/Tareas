using System;

namespace grad_radian
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            float num1=0.000f;
            float pi = 3.1416f;
            float result=0.000f;

            Console.Write("Que operación deseas hacer: ");
            Console.WriteLine("1 -Grado a Radian ");
            Console.WriteLine("2 - Radian a Grado");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Ingrese el valor en grados ");
                    num1= float.Parse(Console.ReadLine());
                    result = ((num1 * pi) / 180);
                    Console.Write("el resultado en gradianes es" + result);
                    break;
                case 2:
                    Console.Write("Ingrese el valor en Radianes ");
                    num1 = float.Parse(Console.ReadLine());
                    result = ((num1 * 180) / pi);
                    Console.Write("el resultado en grados es" + result);
                    break;
                default:
                    Console.Write("Ingrese una opcion valida");
                    break;
            }
            Console.ReadKey();

        }
    }
}
