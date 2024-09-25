namespace ApiColegio.Models
{
    public class Foro
    {
        public int Id { get; set; }
        public required string titulo { get; set; }
        public required string contenido { get; set; }
        public DateTime fechaCreacion { get; set; }
        public required Maestro autor {  get; set; }
        public List<Comentario> comentarios { get; set; }
    }
}
