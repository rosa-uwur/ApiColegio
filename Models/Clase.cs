namespace ApiColegio.Models
{
    public class Clase
    {
        public int Id { get; set; }
        public string nombreClase { get; set; }
        public string nombreMaestro { get; set; }
        public DateOnly FechaAsignacion { get; set; }
    }
}
