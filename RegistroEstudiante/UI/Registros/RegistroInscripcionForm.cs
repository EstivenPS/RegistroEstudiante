using RegistroEstudiante.BLL;
using RegistroEstudiante.DAL;
using RegistroEstudiante.Entidades;
using RegistroEstudiante.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEstudiante.UI.Registros
{
    public partial class RegistroInscripcionForm : Form
    {
        public RegistroInscripcionForm()
        {
            InitializeComponent();
        }

        private void RegistroInscripcionForm_Load(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            IDInscripcionNumericUpDown.Value = 0;
            IDEstudianteNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            ComentarioTextBox.Text = string.Empty;
            MontoTextBox.Text = string.Empty;
            DepositoTextBox.Text = string.Empty;
            BalanceInscripcionTextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void CambiarBalance(int id, decimal balance)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Estudiantes estudiante = new Estudiantes();

            try
            {
                estudiante = db.Estudiantes.Find(id);

                if (estudiante != null)
                {
                    estudiante.Balance += balance;
                    db.Entry(estudiante).State = EntityState.Modified;
                    paso = db.SaveChanges() > 0;                    
                }

                if (!paso)
                {
                    MessageBox.Show("El balance en el Registro de Estudiantes no pudo ser cambiado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
        }

        private Inscripciones LLenaClase()
        {
            Inscripciones inscripcion = new Inscripciones();
            decimal MontoAux = Convert.ToDecimal(MontoTextBox.Text);
            decimal DepositoAux = Convert.ToDecimal(DepositoTextBox.Text);
            decimal BalanceAux = MontoAux - DepositoAux;

            inscripcion.InscripcionId = Convert.ToInt32(IDInscripcionNumericUpDown.Value);
            inscripcion.EstudianteId = Convert.ToInt32(IDEstudianteNumericUpDown.Value);
            inscripcion.Fecha = FechaDateTimePicker.Value;
            inscripcion.Comentarios = ComentarioTextBox.Text;
            inscripcion.Monto = Convert.ToDecimal(MontoTextBox.Text);
            inscripcion.Deposito = Convert.ToDecimal(DepositoTextBox.Text);
            inscripcion.Balance = BalanceAux;         
            
            return inscripcion;
        }

        private void LLenaCampo(Inscripciones inscripcion)
        {
            IDInscripcionNumericUpDown.Value = inscripcion.InscripcionId;
            IDEstudianteNumericUpDown.Value = inscripcion.EstudianteId;
            FechaDateTimePicker.Value = inscripcion.Fecha;
            ComentarioTextBox.Text = inscripcion.Comentarios;
            MontoTextBox.Text = Convert.ToString(inscripcion.Monto);
            DepositoTextBox.Text = Convert.ToString(inscripcion.Deposito);
            BalanceInscripcionTextBox.Text = Convert.ToString(inscripcion.Balance);
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Inscripciones inscripcion = InscripcionesBLL.Buscar((int)IDInscripcionNumericUpDown.Value);
            return (inscripcion != null);
        }

        private void GuardarInscripcionButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Estudiantes estudiante = new Estudiantes();
            Inscripciones inscripcion = new Inscripciones();
            Contexto db = new Contexto();

            try
            {
                inscripcion = LLenaClase();
                CambiarBalance(inscripcion.EstudianteId, inscripcion.Balance);
                estudiante = db.Estudiantes.Find(inscripcion.EstudianteId);

                if (estudiante != null)
                {
                    if (!Validar())
                        return;

                    if (IDInscripcionNumericUpDown.Value == 0)
                        paso = InscripcionesBLL.Guardar(inscripcion);
                    else
                    {
                        if (!ExisteEnLaBaseDeDatos())
                        {
                            MessageBox.Show("No se puede modificar una inscripcion de un estudiante que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        paso = InscripcionesBLL.Modificar(inscripcion);
                    }

                    if (paso)
                    {
                        Limpiar();
                        MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    Limpiar();
                    MessageBox.Show("No se pudo guardar la inscripcion del estudiante, debido a que dicho estudiante no está registrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            
            if(string.IsNullOrWhiteSpace(FechaDateTimePicker.Text))
            {
                MyErrorProvider.SetError(FechaDateTimePicker, "El campo Fecha no puede estar vacio");
                FechaDateTimePicker.Focus();
                paso = false;
            }

            if(string.IsNullOrWhiteSpace(ComentarioTextBox.Text))
            {
                MyErrorProvider.SetError(ComentarioTextBox, "El campo Comentarios no puede estar vacio");
                ComentarioTextBox.Focus();
                paso = false;
            }

            if(string.IsNullOrWhiteSpace(MontoTextBox.Text))
            {
                MyErrorProvider.SetError(MontoTextBox, "El campo Monto no puede estar vacio");
                MontoTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DepositoTextBox.Text)) 
            {
                MyErrorProvider.SetError(DepositoTextBox, "El campo Deposito no puede estar vacio");
                DepositoTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void ComentarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EliminarInscripcionButton_Click(object sender, EventArgs e)
        {
            int id;
            Contexto db = new Contexto();
            Estudiantes estudiante = new Estudiantes();
            Inscripciones inscripcion = new Inscripciones();

            try
            {
                inscripcion = LLenaClase();
                estudiante = db.Estudiantes.Find(inscripcion.EstudianteId);
                                
                CambiarBalance(estudiante.EstudianteID, (inscripcion.Balance * -1));

                MyErrorProvider.Clear();

                int.TryParse(IDInscripcionNumericUpDown.Text, out id);

                Limpiar();

                if (InscripcionesBLL.Eliminar(id))
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MyErrorProvider.SetError(IDInscripcionNumericUpDown, "No se puede eliminar una inscripcion de un estudiante que no existe");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }            
        }

        private void BuscarInscripcionButton_Click(object sender, EventArgs e)
        {
            int id;
            Inscripciones inscripcion = new Inscripciones();
            int.TryParse(IDInscripcionNumericUpDown.Text, out id);

            Limpiar();

            inscripcion = InscripcionesBLL.Buscar(id);

            if(inscripcion != null)
            {
                LLenaCampo(inscripcion);
            }
            else
            {
                MessageBox.Show("Inscripcion de estudiante no encontrada");
            }
        }
    }
}
