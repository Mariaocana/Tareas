using System;

namespace dias_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int choice;
            Console.WriteLine("ingrese un numero del 1 al 7");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("error, ingrese un numero entre 1 y 7");
                    break;
            }
            Console.ReadKey();
        }
    }
}
