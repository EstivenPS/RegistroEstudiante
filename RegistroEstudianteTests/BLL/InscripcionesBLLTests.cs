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
    public class InscripcionesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Inscripciones inscripcion = new Inscripciones();
            inscripcion.InscripcionId = 0;
            inscripcion.EstudianteId = 0;
            inscripcion.Fecha = DateTime.Now;
            inscripcion.Monto = 2;
            inscripcion.Deposito = 1;
            inscripcion.Balance = 1;
            paso = InscripcionesBLL.Guardar(inscripcion);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Inscripciones inscripcion = new Inscripciones();
            inscripcion.InscripcionId = 1;
            inscripcion.EstudianteId = 0;
            inscripcion.Fecha = DateTime.Now;
            inscripcion.Monto = 4;
            inscripcion.Deposito = 1;
            inscripcion.Balance = 3;
            paso = InscripcionesBLL.Modificar(inscripcion);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Inscripciones inscripcion = new Inscripciones();
            inscripcion.InscripcionId = 1;
            inscripcion.EstudianteId = 0;
            inscripcion.Fecha = DateTime.Now;
            inscripcion.Monto = 4;
            inscripcion.Deposito = 1;
            inscripcion.Balance = 3;
            paso = InscripcionesBLL.Eliminar(inscripcion.InscripcionId);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Inscripciones inscripcion = new Inscripciones();
            inscripcion = InscripcionesBLL.Buscar(1);
            Assert.AreEqual(inscripcion != null, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}