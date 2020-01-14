using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEstados
{
    public class Alarma
    {
        public IEstadoAlarma estadoAlarma;

        public Alarma(IEstadoAlarma estadoAlarma)
        {
            this.estadoAlarma = estadoAlarma;
        }

        public void EstablecerEstado(IEstadoAlarma estadoAlarma)
        {
            this.estadoAlarma = estadoAlarma;
        }

        public void Activar()
        {
            estadoAlarma.Activar();
        }

        public void Desactivar()
        {
            estadoAlarma.Desactivar();
        }
    }

    public interface IEstadoAlarma
    {
        void Activar();
        void Desactivar();
    }

    public class EstadoAlarmaActiva : IEstadoAlarma
    {
        private Alarma alarma;

        public void Activar()
        {
            Console.WriteLine("La alarma ya está activa");
        }

        public void Desactivar()
        {
            Console.WriteLine("DESACTIVANDO alarma");
            alarma.Desactivar();
        }

        public void EstablecerContexto()
        {

        }
    }

    public class EstadoAlarmaInactiva : IEstadoAlarma
    {
        private Alarma alarma;

        public void Activar()
        {
            Console.WriteLine("ACTIVANDO alarma");
            alarma.Activar();
        }

        public void Desactivar()
        {
            Console.WriteLine("La alarma ya está desactivada");
        }

        public void EstablecerContexto()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Alarma alarma = new Alarma(new EstadoAlarmaInactiva());

            alarma.EstablecerEstado(new EstadoAlarmaActiva());
            Console.ReadKey();
        }
    }
}
