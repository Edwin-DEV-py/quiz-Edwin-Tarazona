
namespace Quiz1
{
    partial class Reporte
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
            this.Rporte = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Rporte
            // 
            this.Rporte.Location = new System.Drawing.Point(12, 12);
            this.Rporte.Name = "Rporte";
            this.Rporte.Size = new System.Drawing.Size(578, 183);
            this.Rporte.TabIndex = 39;
            this.Rporte.Text = "";
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 271);
            this.Controls.Add(this.Rporte);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox Rporte;
    }
}