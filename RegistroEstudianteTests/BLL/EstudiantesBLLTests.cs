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
            Estudiante estudiante = new Estudiante();
            estudiante.EstudianteID = 0;
            estudiante.Matricula = "0000-0000";
            estudiante.Nombre = "Prueba";
            estudiante.Apellido = "Prueba";
            estudiante.Cedula = "000-0000000-0";
            estudiante.Telefono = "000-000-0000";
            estudiante.Celular = "000-000-0000";
            estudiante.Email = "Prueba@prueba.com";
            estudiante.FechaNacimiento = DateTime.Now;
            estudiante.Sexo = 0;
            estudiante.Balance = 0;
            paso = EstudiantesBLL.Guardar(estudiante);
            Assert.AreEqual(paso, true);

            //Assert.Fail();
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}