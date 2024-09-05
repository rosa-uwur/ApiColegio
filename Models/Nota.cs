namespace ApiColegio.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public int actividadesLibro {  get; set; }
        public int actividadesCuaderno { get; set; }
        public int asistencia { get; set; }
        public int examen {  get; set; }
        public DateTime anio { get; set; }
    }
}
