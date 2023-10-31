using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("accesos", Schema = "gbp_operacional")]
    public class Accesos
    {
        [Key]
        [Column("id_acceso", TypeName = "int")]
        public long id_acceso { get; set; }

        [Column("codigo_acceso")]
        public string codigo_acceso { get; set; }

        [Column("descripcion_acceso")]
        public string descripcion_acceso { get; set; }

        [InverseProperty("acceso")]
        public List<Usuarios> usuariosConAcceso { get; set; }
    }

    [Table("usuarios", Schema = "gbp_operacional")]
    public class Usuarios
    {
        [Key]
        [Column("id_usuario", TypeName = "long")]
        public long id_usuario { get; set; }

        [Column("dni_usuario", TypeName = "string")]
        public string dni_usuario { get; set; }

        [Column("nombre_usuario", TypeName = "string")]
        public string nombre_usuario { get; set; }

        [Column("apellidos_usuario", TypeName = "string")]
        public string apellidos_usuario { get; set; }

        [Column("tlf_usuario", TypeName = "string")]
        public string tlf_usuario { get; set; }

        [Column("email_usuario", TypeName = "string")]
        public string email_usuario { get; set; }

        [Column("clave_usuario", TypeName = "string")]
        public string clave_usuario { get; set; }

        [Column("estaBloqueado_usuario", TypeName = "bool")]
        public bool estaBloqueado_usuario { get; set; }

        [Column("fch_fin_bloqueo_usuario", TypeName = "datetime")]
        public DateTime fch_fin_bloqueo_usuario { get; set; }

        [Column("fch_alta__usuario", TypeName = "datetime")]
        public DateTime fch_alta__usuario { get; set; }

        [Column("fch_baja_usuario", TypeName = "datetime")]
        public DateTime fch_baja_usuario { get; set; }

        [ForeignKey("acceso")]
        public long id_acceso { get; set; }

        [InverseProperty("usuariosConAcceso")]
        public Accesos acceso { get; set; }

        [InverseProperty("usuario")]
        public List<Prestamos> usuariosConPrestamos { get; set; }
    }

    [Table("prestamos", Schema = "gbp_operacional")]
    public class Prestamos
    {
        [Key]
        [Column("id_prestamo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_prestamo { get; set; }

        [ForeignKey("usuario")]
        public long id_usuario { get; set; }
        public Usuarios usuario { get; set; }

        [ForeignKey("libro")]
        public long id_libro { get; set; }
        public Libros libro { get; set; }

        [Column("fch_inicio_prestamo", TypeName = "datetime")]
        public DateTime fch_inicio_prestamo { get; set; }

        [Column("fch_fin_prestamo", TypeName = "datetime")]
        public DateTime fch_fin_prestamo { get; set; }

        [Column("fch_entrega_prestamo", TypeName = "datetime")]
        public DateTime fch_entrega_prestamo { get; set; }

        [ForeignKey("estadoPrestamo")]
        public long id_estado_prestamo { get; set; }
        public EstadosPrestamos estadoPrestamo { get; set; }
    }

    [Table("estadosPrestamos", Schema = "gbp_operacional")]
    public class EstadosPrestamos
    {
        [Key]
        [Column("id_estado_prestamo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_estado_prestamo { get; set; }

        [Column("codigo_estado_prestamo", TypeName = "string")]
        public string codigo_estado_prestamo { get; set; }

        [Column("descripcion_estado_prestamo", TypeName = "string")]
        public string descripcion_estado_prestamo { get; set; }

        [InverseProperty("estadoPrestamo")]
        public List<Prestamos> prestamosEstado { get; set; }
    }

    [Table("libros", Schema = "gbp_operacional")]
    public class Libros
    {
        [Key]
        [Column("id_libro")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_libro { get; set; }

        [Column("isbn_libro", TypeName = "string")]
        public string isbn_libro { get; set; }

        [Column("titulo_libro", TypeName = "string")]
        public string titulo_libro { get; set; }

        [Column("edicion_libro", TypeName = "string")]
        public string edicion_libro { get; set; }

        [Column("cantidad_libro", TypeName = "int")]
        public long cantidad_libro { get; set; }

        [ForeignKey("editorial")]
        public long id_editorial { get; set; }
        public Editoriales editorial { get; set; }

        [ForeignKey("genero")]
        public long id_genero { get; set; }
        public Generos genero { get; set; }

        [ForeignKey("coleccion")]
        public long id_coleccion { get; set; }
        public Colecciones coleccion { get; set; }

        [InverseProperty("libro")]
        public List<Prestamos> librosPrestamos { get; set; }

        //FK para libros-autores
        public virtual List<Autores> Autores { get; set; }
    }


    [Table("autores", Schema = "gbp_operacional")]
    public class Autores
    {
        [Key]
        [Column("id_autor")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_autor { get; set; }

        [Column("nombre_autor", TypeName = "string")]
        public string nombre_autor { get; set; }

        [Column("apellidos_autor", TypeName = "string")]
        public string apellidos_autor { get; set; }

        //FK autores libros
        public virtual List<Libros> Libros { get; set; }
    }

    [Table("colecciones", Schema = "gbp_operacional")]
    public class Colecciones
    {
        [Key]
        [Column("id_coleccion")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_coleccion { get; set; }

        [Column("nombre_coleccion", TypeName = "string")]
        public string nombre_coleccion { get; set; }

        [InverseProperty("coleccion")]
        public List<Libros> librosColeccion { get; set; }
    }

    [Table("rditoriales", Schema = "gbp_operacional")]
    public class Editoriales
    {
        [Key]
        [Column("id_editorial")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_editorial { get; set; }

        [Column("nombre_editorial", TypeName = "string")]
        public string nombre_editorial { get; set; }

        [InverseProperty("editorial")]
        public List<Libros> librosEditoriales { get; set; }
    }

    [Table("generos", Schema = "gbp_operacional")]
    public class Generos
    {
        [Key]
        [Column("id_genero")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_genero { get; set; }

        [Column("nombre_genero", TypeName = "string")]
        public string nombre_genero { get; set; }

        [Column("descripcion_genero", TypeName = "string")]
        public string descripcion_genero { get; set; }

        [InverseProperty("genero")]
        public List<Libros> librosGeneros { get; set; } 
    }
    

}
