
using System;

namespace Quiz1
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabRegistro = new System.Windows.Forms.Label();
            this.LabNombre = new System.Windows.Forms.Label();
            this.LabApellido = new System.Windows.Forms.Label();
            this.CajNombre = new System.Windows.Forms.TextBox();
            this.CajApeliido = new System.Windows.Forms.TextBox();
            this.LabEmail = new System.Windows.Forms.Label();
            this.CajEmail = new System.Windows.Forms.TextBox();
            this.LabGenero = new System.Windows.Forms.Label();
            this.ComGenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DATE = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Nit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CajDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CajContraseña = new System.Windows.Forms.TextBox();
            this.ButCrear = new System.Windows.Forms.Button();
            this.ButAdmin = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CajApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // LabRegistro
            // 
            this.LabRegistro.AutoSize = true;
            this.LabRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRegistro.Location = new System.Drawing.Point(12, 9);
            this.LabRegistro.Name = "LabRegistro";
            this.LabRegistro.Size = new System.Drawing.Size(120, 25);
            this.LabRegistro.TabIndex = 2;
            this.LabRegistro.Text = "Registrate";
            // 
            // LabNombre
            // 
            this.LabNombre.AutoSize = true;
            this.LabNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNombre.Location = new System.Drawing.Point(14, 51);
            this.LabNombre.Name = "LabNombre";
            this.LabNombre.Size = new System.Drawing.Size(67, 16);
            this.LabNombre.TabIndex = 3;
            this.LabNombre.Text = "Nombre:";
            // 
            // LabApellido
            // 
            this.LabApellido.AutoSize = true;
            this.LabApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabApellido.Location = new System.Drawing.Point(143, 51);
            this.LabApellido.Name = "LabApellido";
            this.LabApellido.Size = new System.Drawing.Size(70, 16);
            this.LabApellido.TabIndex = 4;
            this.LabApellido.Text = "Apellido:";
            // 
            // CajNombre
            // 
            this.CajNombre.Location = new System.Drawing.Point(17, 70);
            this.CajNombre.MaxLength = 20;
            this.CajNombre.Name = "CajNombre";
            this.CajNombre.Size = new System.Drawing.Size(115, 20);
            this.CajNombre.TabIndex = 6;
            // 
            // CajApeliido
            // 
            this.CajApeliido.Location = new System.Drawing.Point(146, 70);
            this.CajApeliido.MaxLength = 20;
            this.CajApeliido.Name = "CajApeliido";
            this.CajApeliido.Size = new System.Drawing.Size(115, 20);
            this.CajApeliido.TabIndex = 7;
            // 
            // LabEmail
            // 
            this.LabEmail.AutoSize = true;
            this.LabEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabEmail.Location = new System.Drawing.Point(284, 51);
            this.LabEmail.Name = "LabEmail";
            this.LabEmail.Size = new System.Drawing.Size(51, 16);
            this.LabEmail.TabIndex = 8;
            this.LabEmail.Text = "Email:";
            // 
            // CajEmail
            // 
            this.CajEmail.Location = new System.Drawing.Point(287, 70);
            this.CajEmail.MaxLength = 20;
            this.CajEmail.Name = "CajEmail";
            this.CajEmail.Size = new System.Drawing.Size(283, 20);
            this.CajEmail.TabIndex = 9;
            // 
            // LabGenero
            // 
            this.LabGenero.AutoSize = true;
            this.LabGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabGenero.Location = new System.Drawing.Point(14, 110);
            this.LabGenero.Name = "LabGenero";
            this.LabGenero.Size = new System.Drawing.Size(63, 16);
            this.LabGenero.TabIndex = 10;
            this.LabGenero.Text = "Genero:";
            // 
            // ComGenero
            // 
            this.ComGenero.FormattingEnabled = true;
            this.ComGenero.Items.AddRange(new object[] {
            "H",
            "M"});
            this.ComGenero.Location = new System.Drawing.Point(17, 129);
            this.ComGenero.Name = "ComGenero";
            this.ComGenero.Size = new System.Drawing.Size(95, 21);
            this.ComGenero.TabIndex = 26;
            this.ComGenero.SelectedIndexChanged += new System.EventHandler(this.ComGenero_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha de Nacimiento:";
            // 
            // DATE
            // 
            this.DATE.Location = new System.Drawing.Point(136, 130);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(134, 20);
            this.DATE.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "NIT";
            // 
            // Nit
            // 
            this.Nit.FormattingEnabled = true;
            this.Nit.Items.AddRange(new object[] {
            "CC",
            "TI"});
            this.Nit.Location = new System.Drawing.Point(301, 129);
            this.Nit.Name = "Nit";
            this.Nit.Size = new System.Drawing.Size(54, 21);
            this.Nit.TabIndex = 30;
            this.Nit.SelectedIndexChanged += new System.EventHandler(this.Nit_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Numero:";
            // 
            // CajDocumento
            // 
            this.CajDocumento.Location = new System.Drawing.Point(373, 129);
            this.CajDocumento.MaxLength = 15;
            this.CajDocumento.Name = "CajDocumento";
            this.CajDocumento.Size = new System.Drawing.Size(115, 20);
            this.CajDocumento.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Contraseña:";
            // 
            // CajContraseña
            // 
            this.CajContraseña.Location = new System.Drawing.Point(17, 207);
            this.CajContraseña.MaxLength = 20;
            this.CajContraseña.Name = "CajContraseña";
            this.CajContraseña.PasswordChar = '*';
            this.CajContraseña.Size = new System.Drawing.Size(115, 20);
            this.CajContraseña.TabIndex = 34;
            // 
            // ButCrear
            // 
            this.ButCrear.Location = new System.Drawing.Point(156, 203);
            this.ButCrear.Name = "ButCrear";
            this.ButCrear.Size = new System.Drawing.Size(105, 27);
            this.ButCrear.TabIndex = 35;
            this.ButCrear.Text = "Crear";
            this.ButCrear.UseVisualStyleBackColor = true;
            this.ButCrear.Click += new System.EventHandler(this.ButCrear_Click);
            // 
            // ButAdmin
            // 
            this.ButAdmin.Location = new System.Drawing.Point(1068, 207);
            this.ButAdmin.Name = "ButAdmin";
            this.ButAdmin.Size = new System.Drawing.Size(105, 27);
            this.ButAdmin.TabIndex = 36;
            this.ButAdmin.Text = "Reporte";
            this.ButAdmin.UseVisualStyleBackColor = true;
            this.ButAdmin.Click += new System.EventHandler(this.ButAdmin_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.CajApellido,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv.Location = new System.Drawing.Point(17, 236);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(543, 183);
            this.dgv.TabIndex = 37;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // CajApellido
            // 
            this.CajApellido.HeaderText = "Apellido";
            this.CajApellido.Name = "CajApellido";
            this.CajApellido.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(595, 236);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(578, 183);
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 27);
            this.button1.TabIndex = 39;
            this.button1.Text = "Exportar >>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.ButAdmin);
            this.Controls.Add(this.ButCrear);
            this.Controls.Add(this.CajContraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CajDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DATE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComGenero);
            this.Controls.Add(this.LabGenero);
            this.Controls.Add(this.CajEmail);
            this.Controls.Add(this.LabEmail);
            this.Controls.Add(this.CajApeliido);
            this.Controls.Add(this.CajNombre);
            this.Controls.Add(this.LabApellido);
            this.Controls.Add(this.LabNombre);
            this.Controls.Add(this.LabRegistro);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label LabRegistro;
        private System.Windows.Forms.Label LabNombre;
        private System.Windows.Forms.Label LabApellido;
        private System.Windows.Forms.Label LabEmail;
        private System.Windows.Forms.Label LabGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DATE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Nit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CajContraseña;
        private System.Windows.Forms.Button ButCrear;
        private System.Windows.Forms.Button ButAdmin;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CajApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.TextBox CajNombre;
        public System.Windows.Forms.TextBox CajApeliido;
        public System.Windows.Forms.TextBox CajEmail;
        public System.Windows.Forms.ComboBox ComGenero;
        public System.Windows.Forms.TextBox CajDocumento;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}

