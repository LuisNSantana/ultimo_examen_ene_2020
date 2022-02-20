using System;

namespace punto3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los kilometros del recorrido: ");
            int km = Convert.ToInt32(Console.ReadLine());

            float precio = 25;
            float resultado;
            int operacion;
            float operacion2;

            if (km <= 50)
            {
                
                resultado = precio / km;

                Console.WriteLine("El precio a pagar es de " + precio + " euros " +
                    "cada km cuesta: " + resultado + " euros");
                
            } else if ( km > 50 && km <= 200)
            {
                operacion = km - 50;
                precio +=operacion;
                resultado = precio / km;
                
                Console.WriteLine("El precio a pagar es de " + precio + " euros " +
                   "cada km cuesta: " + resultado + " euros");
            } else if (km > 200 && km < 400)
            {
                operacion = km - 50;
                precio += operacion;
                operacion2 = (precio * 10) / 100;
                precio += operacion2;
                resultado = precio  / km;
                Console.WriteLine("El precio a pagar es de " + precio + " euros " +
                   "cada km cuesta: " + resultado + " euros" );

            }else if (km > 400 && km < 600)
            {
                operacion = km - 50;
                precio += operacion;
                operacion2 = (precio * 15) / 100;
                precio += operacion2;
                resultado = precio / km;
                Console.WriteLine("El precio a pagar es de " + precio + " euros " +
                   "cada km cuesta: " + resultado + " euros");
            } else
            {
                Console.WriteLine("No se realizan viajes de mas de 600km");
            }
        }
    }
}
