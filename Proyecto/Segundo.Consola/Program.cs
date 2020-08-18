using System;
using System.Threading;

namespace Hilo.Consola
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("--------------");
            Console.WriteLine("** Presione Enter para continuar **");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingrese su nombre para continuar ");
            string nombreUsuario = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bienvenido este es un ejemplo de como actua los hilos ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Los hilos pueden trabajar como subprocesos  con su propia linea de tiempo y recursos a nivel paralelo ");

            System.Threading.Thread delantero =
                new System.Threading.Thread(new ThreadStart(DelanteroCorriendo));

            System.Threading.Thread volante =
               new System.Threading.Thread(new ThreadStart(VolanteCorriendo));

            System.Threading.Thread defensor =
              new System.Threading.Thread(new ThreadStart(Defensor));

            System.Threading.Thread arquero =
             new System.Threading.Thread(new ThreadStart(Arquero));



            delantero.Start();
            volante.Start();
            defensor.Start();
            arquero.Start();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"  {nombreUsuario} El ejemplo trata de que que los jugadores tienen que estar moviendose en la Cancha," +
                $" para ello  tiene que trabajar al mismo tiempo");

        }
        public static void DelanteroCorriendo()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Delantero esta corriendo por la pelota " + i);
                System.Threading.Thread.Sleep(200);
            }
        }

        public static void VolanteCorriendo()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Volante esta corriendo y no se cansa " + i);
                System.Threading.Thread.Sleep(200);
            }

        }

        public static void Defensor()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Defensor esta caminando en la cancha " + i);
                System.Threading.Thread.Sleep(200);
            }

        }

        public static void Arquero()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Arquero esta moviendose en la cancha " + i);
                System.Threading.Thread.Sleep(200);
            }

        }


    }

}
