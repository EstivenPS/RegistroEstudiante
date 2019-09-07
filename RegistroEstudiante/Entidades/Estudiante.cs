using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante.Entidades
{
    public class Estudiante
    {
        public int EstudianteID { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Sexo { get; set; }
        public double Balance { get; set; }

        public Estudiante()
        {
            EstudianteID = 0;
            Matricula = string.Empty;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Email = string.Empty;
            FechaNacimiento = DateTime.Now;
            Sexo = 0;
            Balance = 0.0;
        }
    }
}
