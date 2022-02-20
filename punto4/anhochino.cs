using System;

namespace punto4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su anho de nacimiento: ");
            int anho = Convert.ToInt32(Console.ReadLine());
            int operacion = anho % 12;

            switch (operacion)
            {
                case 0:
                    {
                        Console.WriteLine("Su signo es mono");
                    }
                    break;

                case 1:
                    {
                        Console.WriteLine("Su signo es gallo");
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("Su signo es perro");
                    }break;
                case 3:
                    {
                        Console.WriteLine("Su signo es cerdo");
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Su signo es rata");
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Su signo es buey");
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Su signo es tigre");
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Su signo es conejo");
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("Su signo es dragon");
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("Su signo es serpiente");
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("Su signo es caballo");
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("Su signo es cabra");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Ingrese un año valido");
                    }break;
            }
        }
    }
}
