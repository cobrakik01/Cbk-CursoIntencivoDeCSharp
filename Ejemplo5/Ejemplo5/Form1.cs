using LibreriaVB.LibreriaVb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sumador s = new Sumador();
            int suma = s.Sumar(txtNumero.Text, txtNumero2.Text);
            MessageBox.Show(String.Concat(suma));
        }

        
    }
}
