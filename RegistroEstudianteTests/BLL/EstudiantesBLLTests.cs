using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroEstudiante.BLL;
using RegistroEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante.BLL.Tests
{
    [TestClass()]
    public class EstudiantesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteID = 0;
            estudiante.Matricula = "0000-0000";
            estudiante.Nombres = "Prueba";
            estudiante.Apellidos = "Prueba";
            estudiante.Cedula = "000-0000000-0";
            estudiante.Telefono = "000-000-0000";
            estudiante.Celular = "000-000-0000";
            estudiante.Email = "Prueba@prueba.com";
            estudiante.FechaNacimiento = DateTime.Now;
            estudiante.Sexo = 0;
            estudiante.Balance = 0;
            paso = EstudiantesBLL.Guardar(estudiante);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteID = 2;
            estudiante.Matricula = "0000-0000";
            estudiante.Nombres = "Prueba";
            estudiante.Apellidos = "Prueba";
            estudiante.Cedula = "000-0000000-0";
            estudiante.Telefono = "000-000-0000";
            estudiante.Celular = "000-000-0000";
            estudiante.Email = "Prueba@prueba.com";
            estudiante.FechaNacimiento = DateTime.Now;
            estudiante.Sexo = 0;
            estudiante.Balance = 0;
            paso = EstudiantesBLL.Modificar(estudiante);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteID = 2;
            estudiante.Matricula = "0000-0000";
            estudiante.Nombres = "Prueba";
            estudiante.Apellidos = "Prueba";
            estudiante.Cedula = "000-0000000-0";
            estudiante.Telefono = "000-000-0000";
            estudiante.Celular = "000-000-0000";
            estudiante.Email = "Prueba@prueba.com";
            estudiante.FechaNacimiento = DateTime.Now;
            estudiante.Sexo = 0;
            estudiante.Balance = 0;
            paso = EstudiantesBLL.Eliminar(estudiante.EstudianteID);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante = EstudiantesBLL.Buscar(2);
            Assert.AreEqual(estudiante != null, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}