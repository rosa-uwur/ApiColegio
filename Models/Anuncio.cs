namespace ApiColegio.Models
{
    public class Anuncio
    {
        public int Id { get; set; }
        public string titulo { get; set; }
        public string contenido { get; set; }
        public DateTime fechaCreacion {  get; set; }
        public DateTime fechaVencimiento { get; set; }
        public string autor { get; set; }
    }
}
