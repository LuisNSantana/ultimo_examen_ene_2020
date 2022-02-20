using System;

namespace punto2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresar cuantos comensales comerion: ");
            int comensales = Convert.ToInt32(Console.ReadLine());
            double plato;
            double resultado;
            double propina;
            //Segun el enunciado es a partir de mas 4 pero lo hare a partir de mas 5 comensales
            //ya que no tiene sentido por que de a 2 a 5 comensales vale 18 entonces a partir de mas 4 no
            //puede valer 16
            
            if (comensales >= 2 && comensales <= 5)
            {
                plato = 18;
                resultado= comensales*plato;
                propina = (resultado * 10) / 100;
                Console.WriteLine("Para " + comensales+ "  comensales" + " el plato sale a " + plato +" euros"+ " siendo el total a cobrar de " +
                    resultado + " euros" + " deberias dejar " + propina + " euros de propina");
            } else if (comensales > 5)
            {
                plato = 16;
                resultado = comensales * plato;
                propina = (resultado * 10) / 100;
                Console.WriteLine("Para " + comensales + "  comensales" + " el plato sale a " + plato + " euros" + " siendo el total a cobrar de " +
                    resultado + " euros" + " deberias dejar " + propina + " euros de propina");

            }else
            {
                plato = 25;
                resultado = comensales * plato;
                propina = (resultado * 10) / 100;
                Console.WriteLine("Para " + comensales + "  comensales" + " el plato sale a " + plato + " euros" + " siendo el total a cobrar de " +
                    resultado + " euros" + " deberias dejar " + propina + " euros de propina");
            }
        }
    }
}
