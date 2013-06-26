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
    public partial class Form1 : Form
    {
        private SortedList<string, Libro> listaLibros;

        internal SortedList<string, Libro> ObtenerLibros()
        {
            return this.listaLibros;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libro lib = new Libro();
            lib.Titulo = txtTitulo.Text;
            lib.Autor = txtAutor.Text;
            lib.Editorial = txtEditorial.Text;
            lib.Descripcion = txtDescripcion.Text;

            if (this.listaLibros.Keys.Contains(lib.Titulo))
            {
                MessageBox.Show("El libro " + lib.Titulo + " Ya existe!!!");
            }
            else
            {
                this.listaLibros.Add(lib.Titulo, lib);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaLibros = new SortedList<string, Libro>();
        }

        private void buscarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarLibros v = new MostrarLibros();
            v.ShowDialog(this);
        }

        internal void LibroSeleccionado(string titulo)
        {
            if (listaLibros.Keys.Contains(titulo))
            {
                Libro lib = listaLibros[titulo];
                this.LibroSeleccionado(lib);
            }
        }

        internal void LibroSeleccionado(Libro lib)
        {
            txtTitulo.Text = lib.Titulo;
            txtAutor.Text = lib.Autor;
            txtEditorial.Text = lib.Editorial;
            txtDescripcion.Text = lib.Descripcion;
        }

        internal void eliminar(string titulo)
        {
            if (listaLibros.Keys.Contains(titulo))
            {

                if (listaLibros.Remove(titulo))
                {
                    MessageBox.Show("El libro" + titulo + "se ha eliminado");
                }

            }
        }
    }
}
