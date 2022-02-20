using System;

namespace examenProgramacionEne
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero entero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int ejercicio = ((((num * 5 +1) * 2) - 12) / 10)- num ;

            double factorial = 1;

            Console.WriteLine("El resultado es: " + ejercicio);

            if (num < 0)
            {
                factorial = factorial * num;
                num--;

                Console.WriteLine("El factorial es: " + num);

            }else if ((factorial / factorial) == 0 && (factorial / num) == 0)
            {
                Console.WriteLine("El resultado si es primo :" + factorial);
            }
            else
            {
                ;
            }
        }
    }
}
