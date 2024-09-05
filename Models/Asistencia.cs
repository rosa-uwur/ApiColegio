namespace ApiColegio.Models
{
    public class Asistencia
    {
        public int Id { get; set; } 
        public Alumno alumno { get; set; }
        public DateOnly fecha { get; set; }
        public Boolean asistio {  get; set; }   

    }
}
