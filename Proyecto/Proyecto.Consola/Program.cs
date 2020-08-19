using System;
using System.Threading;

namespace Proyecto.Consola
{
    class Program
    {
        //mientras tenga el valor de true  se va estar ejecutando
        private static bool ejecutar = true;
        static void Main(string[] args)
        {
            Console.WriteLine("--------------");
            Console.WriteLine("** Presione Enter para continuar **");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingrese su nombre para continuar ");
            string nombreUsuario = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bienvenido este es un El Ejemplo numero 1");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Los hilos pueden trabajar como subprocesos  con su propia linea de tiempo y recursos a nivel paralelo ");
            Console.ReadKey();

            int m = 0;
            int x = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
           

            //Thread MiHilo = new Thread(Mensaje);
            //MiHilo.Start();

            for (x = 0; x < 8; x++)
            {
                Thread miHilo = new Thread(MensajeM);
                miHilo.Start(x);
            }

            while (ejecutar)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hola muchachones como estan  esto es el hilo general {0}", m);
                
                m++;

                if (m == 1000)
                    ejecutar = false;

            }

            watch.Stop();

            var ticksTranscurridos = watch.ElapsedTicks;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"El tiempo transcurriedo de la repeticion de los mensajes fué de {ticksTranscurridos} ticks");
            //tiempo del proceso en milisegundos
            var milisegundoTranscurridos = watch.ElapsedMilliseconds;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"El tiempo transcurriedo de la repeticion de los mensaje fué de {milisegundoTranscurridos} milisegundos");


              

        }

        static void Mensaje()
        {
            //crear una variable n que me va aservir de contador 
            int n = 0;
            //aqui tenemos un ciclo while mientra ejecutar tenga el valor de true  esto se va repetiendo el saludo
            while (ejecutar)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saludos desde el hilo {0}", n);
                n++;


            }
        }

        static void MensajeM(object o)
        {
            int n = 0;

            while (ejecutar)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Saludos desde el hilo {0} - {1} ", o, n);
                n++;
            }
        }
    }
}
//conesto podemos comprobar que los dos hilos estan trbajando simultaneamete 