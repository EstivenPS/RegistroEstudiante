namespace RegistroEstudiante.UI.Registros
{
    partial class RegistroInscripcionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroInscripcionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IDInscripcionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IDEstudianteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.DepositoTextBox = new System.Windows.Forms.TextBox();
            this.BalanceInscripcionTextBox = new System.Windows.Forms.TextBox();
            this.ComentarioTextBox = new System.Windows.Forms.TextBox();
            this.NuevoInscripcionButton = new System.Windows.Forms.Button();
            this.GuardarInscripcionButton = new System.Windows.Forms.Button();
            this.EliminarInscripcionButton = new System.Windows.Forms.Button();
            this.BuscarInscripcionButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDInscripcionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDEstudianteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de la Inscripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID del Estudiante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comentarios:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Deposito:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Balance:";
            // 
            // IDInscripcionNumericUpDown
            // 
            this.IDInscripcionNumericUpDown.Location = new System.Drawing.Point(115, 12);
            this.IDInscripcionNumericUpDown.Name = "IDInscripcionNumericUpDown";
            this.IDInscripcionNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.IDInscripcionNumericUpDown.TabIndex = 7;
            // 
            // IDEstudianteNumericUpDown
            // 
            this.IDEstudianteNumericUpDown.Location = new System.Drawing.Point(115, 40);
            this.IDEstudianteNumericUpDown.Name = "IDEstudianteNumericUpDown";
            this.IDEstudianteNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.IDEstudianteNumericUpDown.TabIndex = 8;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(115, 66);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechaDateTimePicker.TabIndex = 9;
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(115, 93);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(200, 20);
            this.MontoTextBox.TabIndex = 11;
            // 
            // DepositoTextBox
            // 
            this.DepositoTextBox.Location = new System.Drawing.Point(115, 119);
            this.DepositoTextBox.Name = "DepositoTextBox";
            this.DepositoTextBox.Size = new System.Drawing.Size(200, 20);
            this.DepositoTextBox.TabIndex = 12;
            // 
            // BalanceInscripcionTextBox
            // 
            this.BalanceInscripcionTextBox.Location = new System.Drawing.Point(115, 145);
            this.BalanceInscripcionTextBox.Name = "BalanceInscripcionTextBox";
            this.BalanceInscripcionTextBox.ReadOnly = true;
            this.BalanceInscripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.BalanceInscripcionTextBox.TabIndex = 13;
            // 
            // ComentarioTextBox
            // 
            this.ComentarioTextBox.Location = new System.Drawing.Point(115, 173);
            this.ComentarioTextBox.Multiline = true;
            this.ComentarioTextBox.Name = "ComentarioTextBox";
            this.ComentarioTextBox.Size = new System.Drawing.Size(200, 68);
            this.ComentarioTextBox.TabIndex = 14;
            this.ComentarioTextBox.TextChanged += new System.EventHandler(this.ComentarioTextBox_TextChanged);
            // 
            // NuevoInscripcionButton
            // 
            this.NuevoInscripcionButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoInscripcionButton.Image")));
            this.NuevoInscripcionButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoInscripcionButton.Location = new System.Drawing.Point(28, 254);
            this.NuevoInscripcionButton.Name = "NuevoInscripcionButton";
            this.NuevoInscripcionButton.Size = new System.Drawing.Size(75, 38);
            this.NuevoInscripcionButton.TabIndex = 15;
            this.NuevoInscripcionButton.Text = "Nuevo";
            this.NuevoInscripcionButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoInscripcionButton.UseVisualStyleBackColor = true;
            this.NuevoInscripcionButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GuardarInscripcionButton
            // 
            this.GuardarInscripcionButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarInscripcionButton.Image")));
            this.GuardarInscripcionButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarInscripcionButton.Location = new System.Drawing.Point(122, 254);
            this.GuardarInscripcionButton.Name = "GuardarInscripcionButton";
            this.GuardarInscripcionButton.Size = new System.Drawing.Size(75, 38);
            this.GuardarInscripcionButton.TabIndex = 16;
            this.GuardarInscripcionButton.Text = "Guardar";
            this.GuardarInscripcionButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarInscripcionButton.UseVisualStyleBackColor = true;
            this.GuardarInscripcionButton.Click += new System.EventHandler(this.GuardarInscripcionButton_Click);
            // 
            // EliminarInscripcionButton
            // 
            this.EliminarInscripcionButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarInscripcionButton.Image")));
            this.EliminarInscripcionButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarInscripcionButton.Location = new System.Drawing.Point(221, 254);
            this.EliminarInscripcionButton.Name = "EliminarInscripcionButton";
            this.EliminarInscripcionButton.Size = new System.Drawing.Size(75, 38);
            this.EliminarInscripcionButton.TabIndex = 17;
            this.EliminarInscripcionButton.Text = "Eliminar";
            this.EliminarInscripcionButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarInscripcionButton.UseVisualStyleBackColor = true;
            this.EliminarInscripcionButton.Click += new System.EventHandler(this.EliminarInscripcionButton_Click);
            // 
            // BuscarInscripcionButton
            // 
            this.BuscarInscripcionButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarInscripcionButton.Image")));
            this.BuscarInscripcionButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarInscripcionButton.Location = new System.Drawing.Point(230, 12);
            this.BuscarInscripcionButton.Name = "BuscarInscripcionButton";
            this.BuscarInscripcionButton.Size = new System.Drawing.Size(85, 40);
            this.BuscarInscripcionButton.TabIndex = 18;
            this.BuscarInscripcionButton.Text = "Buscar";
            this.BuscarInscripcionButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarInscripcionButton.UseVisualStyleBackColor = true;
            this.BuscarInscripcionButton.Click += new System.EventHandler(this.BuscarInscripcionButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // RegistroInscripcionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 300);
            this.Controls.Add(this.BuscarInscripcionButton);
            this.Controls.Add(this.EliminarInscripcionButton);
            this.Controls.Add(this.GuardarInscripcionButton);
            this.Controls.Add(this.NuevoInscripcionButton);
            this.Controls.Add(this.ComentarioTextBox);
            this.Controls.Add(this.BalanceInscripcionTextBox);
            this.Controls.Add(this.DepositoTextBox);
            this.Controls.Add(this.MontoTextBox);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.IDEstudianteNumericUpDown);
            this.Controls.Add(this.IDInscripcionNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroInscripcionForm";
            this.Text = "Registro de Inscripción";
            this.Load += new System.EventHandler(this.RegistroInscripcionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDInscripcionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDEstudianteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown IDInscripcionNumericUpDown;
        private System.Windows.Forms.NumericUpDown IDEstudianteNumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.TextBox DepositoTextBox;
        private System.Windows.Forms.TextBox BalanceInscripcionTextBox;
        private System.Windows.Forms.TextBox ComentarioTextBox;
        private System.Windows.Forms.Button NuevoInscripcionButton;
        private System.Windows.Forms.Button GuardarInscripcionButton;
        private System.Windows.Forms.Button EliminarInscripcionButton;
        private System.Windows.Forms.Button BuscarInscripcionButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}