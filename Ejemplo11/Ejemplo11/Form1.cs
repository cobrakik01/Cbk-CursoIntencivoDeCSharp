using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo11
{
    public partial class Form1 : Form
    {
        private TextBox txtb;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtb == txtC)
            {
                double gc = double.Parse(txtC.Text);
                double gf = (gc * 9 / 5) + 32;
                txtF.Text = string.Format("{0:F2}", gf);
            }
            if (txtb == txtF)
            {
                double gf = double.Parse(txtF.Text);
                double gc = ((gf - 32) * 5) / 9;
                txtC.Text = string.Format("{0:F2}", gc);
            }
        }

        private void TextChange(object sender, EventArgs e)
        {
            txtb = sender as TextBox;
        }

        private void Validando(object sender, CancelEventArgs e)
        {
            TextBox t = sender as TextBox;
            try
            {
                double.Parse(t.Text);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                t.SelectAll();
                proveedorDeErrores.SetError(t, ex.Message);

            }
        }

        private void Validado(object sender, EventArgs e)
        {
            proveedorDeErrores.Clear();
        }
    }
}

