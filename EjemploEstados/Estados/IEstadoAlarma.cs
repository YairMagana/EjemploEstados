namespace EjemploEstados
{
    public interface IEstadoAlarma
    {
        void AlarmaActiva();
        void AlarmaNoActiva();
        void EstablecerContexto(Alarma alarma);
    }
}
