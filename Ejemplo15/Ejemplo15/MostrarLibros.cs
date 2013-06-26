using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo15
{
    public partial class MostrarLibros : Form
    {
        public MostrarLibros()
        {
            InitializeComponent();
        }

        private void MostrarLibros_Load(object sender, EventArgs e)
        {
            this.cargarLibros();  
        }

        public void cargarLibros() {
            Form1 f = (this.Owner as Form1);
            SortedList<string, Libro> lista = f.ObtenerLibros();
            lbLibros.Items.Clear();
            foreach (KeyValuePair<string, Libro> pair in lista)
            {
                Libro lib = pair.Value;
                lbLibros.Items.Add(lib);
            }
        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string titulo = this.lbLibros.SelectedItem.ToString();
            Form1 f = (this.Owner as Form1);
            f.LibroSeleccionado(titulo);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string titulo = this.lbLibros.SelectedItem.ToString();
            Form1 f = (this.Owner as Form1);
            f.eliminar(titulo);
            cargarLibros();
        }
    }
}
