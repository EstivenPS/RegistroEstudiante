using RegistroEstudiante.BLL;
using RegistroEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEstudiante
{
    public partial class RegistroEstudianteForm : Form
    {
        public RegistroEstudianteForm()
        {
            InitializeComponent();
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();

            int id;
            int.TryParse(IDNumericUpDown.Text, out id);

            Limpiar();

            if (EstudiantesBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyerrorProvider.SetError(IDNumericUpDown, "No se puede eliminar un estudiante que no existe");
        }

        private void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            MatriculamaskedTextBox.Text = string.Empty;
            NombreTextBox.Text = string.Empty;
            ApellidoTextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            CelularmaskedTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            FechaNacimientoDateTimePicker.Value = DateTime.Now;
            MyerrorProvider.Clear();

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Estudiante LLenaClase()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.EstudianteID = Convert.ToInt32(IDNumericUpDown.Value);
            estudiante.Matricula = MatriculamaskedTextBox.Text;
            estudiante.Apellido = ApellidoTextBox.Text;
            estudiante.Cedula = CedulamaskedTextBox.Text;
            estudiante.Telefono = TelefonomaskedTextBox.Text;
            estudiante.Celular = CelularmaskedTextBox.Text;
            estudiante.Email = EmailTextBox.Text;
            estudiante.FechaNacimiento = FechaNacimientoDateTimePicker.Value;
            estudiante.Sexo = SexoComboBox.SelectedIndex;
            estudiante.Balance = Convert.ToDouble(BalanceTextBox.Text);

            return estudiante;
        }

        private void LLenaCampo(Estudiante estudiante)
        {
            IDNumericUpDown.Value = estudiante.EstudianteID;
            MatriculamaskedTextBox.Text = estudiante.Matricula;
            NombreTextBox.Text = estudiante.Nombre;
            ApellidoTextBox.Text = estudiante.Apellido;
            CedulamaskedTextBox.Text = estudiante.Cedula;
            TelefonomaskedTextBox.Text = estudiante.Telefono;
            CelularmaskedTextBox.Text = estudiante.Celular;
            EmailTextBox.Text = estudiante.Email;
            FechaNacimientoDateTimePicker.Value = estudiante.FechaNacimiento;
            SexoComboBox.SelectedIndex = estudiante.Sexo;
            BalanceTextBox.Text = Convert.ToString(estudiante.Balance);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Estudiante estudiante;
            bool paso = false;

            if (!Validar())
                return;

            estudiante = LLenaClase();

            if (IDNumericUpDown.Value == 0)
                paso = EstudiantesBLL.Guardar(estudiante);
            else
            {
                if(!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un estudiante que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = EstudiantesBLL.Modificar(estudiante);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool Validar()
        {
            bool paso = false;
            MyerrorProvider.Clear();
                        
            if (string.IsNullOrWhiteSpace(MatriculamaskedTextBox.Text.Replace("-", "")))
            {
                MyerrorProvider.SetError(MatriculamaskedTextBox, "El campo Matricula no puede estar vacio");
                MatriculamaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyerrorProvider.SetError(NombreTextBox, "El campo Nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ApellidoTextBox.Text))
            {
                MyerrorProvider.SetError(ApellidoTextBox, "El campo Apellido no puede estar vacio");
                ApellidoTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulamaskedTextBox.Text.Replace("-","")))
            {
                MyerrorProvider.SetError(CedulamaskedTextBox, "El campo Cedula no puede estar vacio");
                CedulamaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text.Replace("-","")))
            {
                MyerrorProvider.SetError(TelefonomaskedTextBox, "El campo Telefono no puede estar vacio");
                TelefonomaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CelularmaskedTextBox.Text.Replace("-","")))
            {
                MyerrorProvider.SetError(CelularmaskedTextBox, "El campo Celular no puede estar vacio");
                CelularmaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MyerrorProvider.SetError(EmailTextBox, "El campo Email no puede estar vacio");
                EmailTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(FechaNacimientoDateTimePicker.Text))
            {
                MyerrorProvider.SetError(FechaNacimientoDateTimePicker, "El campo Fecha de nacimiento no puede estar vacio");
                FechaNacimientoDateTimePicker.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(SexoComboBox.Text))
            {
                MyerrorProvider.SetError(SexoComboBox, "El campo Sexo no puede estar vacio");
                SexoComboBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(BalanceTextBox.Text))
            {
                MyerrorProvider.SetError(BalanceTextBox, "El campo Balance no puede estar vacio");
                BalanceTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Estudiante estudiante = EstudiantesBLL.Buscar((int)IDNumericUpDown.Value);
            return (estudiante != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Estudiante estudiante = new Estudiante();
            int.TryParse(IDNumericUpDown.Text, out id);

            Limpiar();

            estudiante = EstudiantesBLL.Buscar(id);

            if(estudiante != null)
            {
                MessageBox.Show("Estudiante Encontrado");
                LLenaCampo(estudiante);
            }
            else
            {
                MessageBox.Show("Estudiante No Encontrado");
            }
        }
    }
}
