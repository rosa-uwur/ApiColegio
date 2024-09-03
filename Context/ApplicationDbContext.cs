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

    }
}
