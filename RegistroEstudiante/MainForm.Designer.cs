namespace RegistroEstudiante
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeInscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeInscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroEstudiantesToolStripMenuItem,
            this.registroDeInscripcionesToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroEstudiantesToolStripMenuItem
            // 
            this.registroEstudiantesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroEstudiantesToolStripMenuItem.Image")));
            this.registroEstudiantesToolStripMenuItem.Name = "registroEstudiantesToolStripMenuItem";
            this.registroEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.registroEstudiantesToolStripMenuItem.Text = "Registro de Estudiantes";
            this.registroEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.RegistroEstudiantesToolStripMenuItem_Click);
            // 
            // registroDeInscripcionesToolStripMenuItem
            // 
            this.registroDeInscripcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeInscripcionesToolStripMenuItem.Image")));
            this.registroDeInscripcionesToolStripMenuItem.Name = "registroDeInscripcionesToolStripMenuItem";
            this.registroDeInscripcionesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.registroDeInscripcionesToolStripMenuItem.Text = "Registro de Inscripciones";
            this.registroDeInscripcionesToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeInscripcionesToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeEstudiantesToolStripMenuItem,
            this.consultaDeInscripcionesToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDeEstudiantesToolStripMenuItem
            // 
            this.consultaDeEstudiantesToolStripMenuItem.Name = "consultaDeEstudiantesToolStripMenuItem";
            this.consultaDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.consultaDeEstudiantesToolStripMenuItem.Text = "Consulta de Estudiantes";
            this.consultaDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.ConsultaDeEstudiantesToolStripMenuItem_Click);
            // 
            // consultaDeInscripcionesToolStripMenuItem
            // 
            this.consultaDeInscripcionesToolStripMenuItem.Name = "consultaDeInscripcionesToolStripMenuItem";
            this.consultaDeInscripcionesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.consultaDeInscripcionesToolStripMenuItem.Text = "Consulta de Inscripciones";
            this.consultaDeInscripcionesToolStripMenuItem.Click += new System.EventHandler(this.ConsultaDeInscripcionesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeInscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeInscripcionesToolStripMenuItem;
    }
}