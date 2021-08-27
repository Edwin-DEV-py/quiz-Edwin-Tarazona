using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        public void ComGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComGenero.Items.Add("H");
            ComGenero.Items.Add("M");
        }

        private void Nit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nit.Items.Add("CC");
            Nit.Items.Add("TI");
        }

        private void ButCrear_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgv);
            fila.Cells[0].Value =CajDocumento.Text;
            fila.Cells[1].Value =CajNombre.Text;
            fila.Cells[2].Value =CajApeliido.Text;
            fila.Cells[3].Value =ComGenero.Text;
            fila.Cells[4].Value =CajEmail.Text;

            dgv.Rows.Add(fila);
            CajDocumento.Text = "";
            CajNombre.Text = "";
            CajApeliido.Text="";
            ComGenero.Text = "";
            CajEmail.Text = "";

            
        }

       private void ButAdmin_Click(object sender, EventArgs e)
        {
            Reporte rp = new Reporte();
            rp.Rporte.Text = richTextBox1.Text;
            rp.Show();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {

                richTextBox1.Text = richTextBox1.Text;

                for (int j = 0; j < dgv.Columns.Count; j++)
                {

                    richTextBox1.Text = richTextBox1.Text + "        " + dgv.Rows[i].Cells[j].Value.ToString() + "        ";

                }

                richTextBox1.Text = richTextBox1.Text + "\n";
                richTextBox1.Text = richTextBox1.Text + "-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
                richTextBox1.Text = richTextBox1.Text + "\n";
            }

        }
    }
}
