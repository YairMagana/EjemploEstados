using System;

namespace EjemploEstados
{
    public class EstadoAlarmaInactiva : IEstadoAlarma
    {
        private Alarma alarma;

        public void AlarmaActiva()
        {
            Console.WriteLine("ACTIVANDO alarma\n");
            alarma.EstablecerEstado(new EstadoAlarmaActiva());
        }

        public void AlarmaNoActiva()
        {
            Console.WriteLine("La alarma ya está desactivada\n");
        }

        public void EstablecerContexto(Alarma alarma)
        {
            this.alarma = alarma;
        }
    }
}
