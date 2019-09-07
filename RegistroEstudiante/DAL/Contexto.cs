using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroEstudiante.Entidades;
using System.Data.Entity;

namespace RegistroEstudiante.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }

        public Contexto() : base("ConStr") { }
    }
}
