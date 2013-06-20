using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            ver();
        }

        private void ver()
        {
            if (txtNombre.Text.Length <= 0
                || txtApellido.Text.Length <= 0
                || txtContrasenia.Text.Length < 4
                || txtContrasenia.Text.ToLower().Equals(txtNombre.Text.ToLower())
                || txtContrasenia.Text.ToLower().Equals(txtApellido.Text.ToLower())
                || txtContrasenia.Text.ToLower().Equals(txtUsuario.Text.ToLower())
                || !txtCContrasenia.Text.Equals(txtContrasenia.Text))
            {
                btnCrear.Enabled = false;
            }
            else
            {
                btnCrear.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ver();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\cobrakik\Documents\usuarios.txt";
            string []datos = new string[]{
                txtNombre.Text,
                txtApellido.Text,
                txtUsuario.Text,
                txtContrasenia.Text
            };
            System.IO.File.WriteAllLines(path, datos);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //this.Close();// Cierra la ventana actual
            Application.Exit(); // Termina la aplicacion completa
        }

    }
}
