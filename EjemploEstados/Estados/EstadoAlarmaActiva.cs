using System;

namespace EjemploEstados
{
    public class EstadoAlarmaActiva : IEstadoAlarma
    {
        private Alarma alarma;

        public void AlarmaActiva()
        {
            Console.WriteLine("La alarma ya está activa\n");
        }

        public void AlarmaNoActiva()
        {
            Console.WriteLine("DESACTIVANDO alarma\n");
            alarma.EstablecerEstado(new EstadoAlarmaInactiva());
        }

        public void EstablecerContexto(Alarma alarma)
        {
            this.alarma = alarma;
        }
    }
}
