using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string contenido = txtContenido.Text;
                string path = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(path, contenido);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string texto = System.IO.File.ReadAllText(path);
                txtContenido.Text = texto;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Font fuente = fontDialog1.Font;
                txtContenido.Font = fuente;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtContenido.Cut();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            txtContenido.Copy();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txtContenido.Paste();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = listaFuentes.SelectedIndex;
            Font f = null;
            switch (n)
            {
                case 0:
                    f = new Font(FontFamily.GenericMonospace, 12, FontStyle.Bold);
                    break;
                case 1:
                    f = new Font(FontFamily.GenericMonospace, 12, FontStyle.Italic);
                    break;
                case 2:
                    f = new Font(FontFamily.GenericMonospace, 12, FontStyle.Strikeout);
                    break;
            }
            txtContenido.Font = f;
        }
               private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
    }
}
