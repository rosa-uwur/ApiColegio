using ApiColegio.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiColegio.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        public DbSet<Alumno> Alumnos { get; set;}

        public DbSet<Maestro> Maestros { get; set;}

        public DbSet<Clase> Clases { get; set;}
        public DbSet<Nota> Notas { get; set;}
        public DbSet<Anuncio> Anuncios { get; set; }

        public DbSet<ApiColegio.Models.Asistencia> Asistencia { get; set; } = default!;
        public DbSet<Foro> Foros { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

    }
}
