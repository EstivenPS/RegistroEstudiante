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
            re.Show();
        }
    }
}
