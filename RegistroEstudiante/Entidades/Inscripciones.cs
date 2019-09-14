using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante.Entidades
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        public DateTime Fecha { get; set; }
        public int EstudianteId { get; set; }
        public string Comentarios { get; set; }
        public decimal Monto { get; set; }
        public decimal Deposito { get; set; }
        public decimal Balance { get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            Fecha = DateTime.Now;
            EstudianteId = 0;
            Comentarios = string.Empty;
            Monto = 0;
            Deposito = 0;
            Balance = 0;
        }
    }
}
