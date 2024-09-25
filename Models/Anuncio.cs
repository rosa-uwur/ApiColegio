namespace ApiColegio.Models
{
    public class Anuncio
    {
        public int Id { get; set; }
        public required string titulo { get; set; }
        public required string contenido { get; set; }
        public DateTime fechaCreacion {  get; set; }
        public DateTime fechaVencimiento { get; set; }
        public required string autor { get; set; }
    }
}
