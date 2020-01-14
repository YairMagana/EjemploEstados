using System;

namespace EjemploEstados
{
    public class Alarma
    {
        public IEstadoAlarma estadoAlarma;

        public Alarma(IEstadoAlarma estadoAlarma)
        {
            EstablecerEstado(estadoAlarma);
        }

        public void EstablecerEstado(IEstadoAlarma estadoAlarma)
        {
            Console.WriteLine($"Nuevo Estado: {estadoAlarma.GetType().ToString()}\n");
            this.estadoAlarma = estadoAlarma;
            this.estadoAlarma.EstablecerContexto(this);
        }

        public void Activar()
        {
            estadoAlarma.AlarmaActiva();
        }

        public void Desactivar()
        {
            estadoAlarma.AlarmaNoActiva();
        }
    }
}
