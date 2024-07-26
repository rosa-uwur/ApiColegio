using System.Globalization;

namespace ApiColegio.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public string primerNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoNombre { get; set; }
        public string segundoApellido { get;  set; }
        public int telefono { get; set; }
        public string email { get; set; }
        public string cui {  get; set; }

    }
}
