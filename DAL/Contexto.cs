using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
        // Se define el contexto de conexión a base de datos, que después
        // será instanciado como servicio para cada sesión https de usuario.
        public class Contexto : DbContext
        {
            // Se define un constructor que nos permita generar el contexto
            // como servicio desde el contenedor de servicios de la sesión https
            // de usuario.
            public Contexto(DbContextOptions<Contexto> options) : base(options)
            {
            }
            // Aseguramos el uso de Ids autoincrementales.
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.UseSerialColumns();
            }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
        public DbSet<EstadosPrestamos> EstadosPrestamos { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Editoriales> Editoriales { get; set; }
        public DbSet<Generos> Generos { get; set; }
        public DbSet<Colecciones> Colecciones { get; set; }
        public DbSet<Autores> Autores { get; set; }
        public DbSet<RelAutoresLibros> RelAutoresLibros { get; set; }

    }
}
