namespace ApiColegio.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public required string contenido { get; set; }
        public DateTime fechaComentario { get; set; }
        public required Usuario autor {  get; set; }
        public required Foro foro { get; set; }

    }
}
