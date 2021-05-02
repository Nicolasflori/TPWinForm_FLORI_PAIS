using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Negocio;

namespace Form1
{
    public partial class Form1 : Form
    {
        private List<Articulos> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrilla();

        }
        private void cargarGrilla()
        {
            NegocioArticulos negocio = new NegocioArticulos();

            try
            {
                listaArticulos = negocio.listar();
                dataGridViewPrincipal.DataSource = listaArticulos;
                dataGridViewPrincipal.Columns["ImagenUrl"].Visible = false;
                cargarImagen(listaArticulos[0].ImagenURl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void image_click(object sender, MouseEventArgs e)
        {
            try
            {
                Articulos seleccionado = (Articulos)dataGridViewPrincipal.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenURl);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo encontrar la imagen");
            }

        }

        private void cargarImagen(string imagen)
        {
            pictureBox1.Load(imagen);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarArt agregar = new FormAgregarArt();
            agregar.ShowDialog();
            cargarGrilla();

        }

        private void buttonDetalles_Click(object sender, EventArgs e)
        {
            FormVerDetalles detalle = new FormVerDetalles();
            detalle.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado = (Articulos)dataGridViewPrincipal.CurrentRow.DataBoundItem;
            NegocioArticulos negocio = new NegocioArticulos();
            try
            {
                if (MessageBox.Show("¿Estás seguro de eliminar el Articulo Seleccionado?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado.ID);
                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
