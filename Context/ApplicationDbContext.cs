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
<<<<<<< HEAD
        public DbSet<ApiColegio.Models.Asistencia> Asistencia { get; set; } = default!;
=======
>>>>>>> 3b70a0cda0be13282bda415599804b5faf402f2c


    }
}
