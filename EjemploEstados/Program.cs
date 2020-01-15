using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEstados
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarma alarma = new Alarma(new EstadoAlarmaInactiva());

            string opt = "1";
            while (opt == "1" || opt == "2")
            {
                Console.WriteLine("1. Activar Alarma\n2. Desactivar Alarma");

                opt = Console.ReadLine();
                if (opt == "1")
                {
                    alarma.Activar();
                }
                else
                {
                    alarma.Desactivar();
                }
            }
        }
    }
}
