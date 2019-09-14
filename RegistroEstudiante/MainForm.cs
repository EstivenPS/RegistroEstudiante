using RegistroEstudiante.UI.Consultas;
using RegistroEstudiante.UI.Registros;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEstudianteForm re = new RegistroEstudianteForm();
            re.MdiParent = this;
            re.Show();
        }

        private void ConsultaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEstudianteForm ce = new ConsultaEstudianteForm();
            ce.MdiParent = this;
            ce.Show();
        }

        private void RegistroDeInscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroInscripcionForm ri = new RegistroInscripcionForm();
            ri.MdiParent = this;
            ri.Show();
        }

        private void ConsultaDeInscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaInscripcionForm ci = new ConsultaInscripcionForm();
            ci.MdiParent = this;
            ci.Show();
        }
    }
}
