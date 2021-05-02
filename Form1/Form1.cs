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
                LOGO.Load("https://topcbd.deals/wp-content/uploads/2020/01/farmacy.png");
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
                pictureBox1.Load("https://www.freundferreteria.com/Productos/GetImagenProductoPrincipal?idProducto=f3d7edf5-20b4-4688-b6b2-ace3de7e219c&width=250&height=250&qa=75&ext=.jpg");
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
            Articulos seleccionado = getCurrentArticulo();
            FormVerDetalles detalle = new FormVerDetalles(seleccionado);
            detalle.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado = getCurrentArticulo();
            NegocioArticulos negocio = new NegocioArticulos();
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el Articulo Seleccionado?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado = (Articulos)dataGridViewPrincipal.CurrentRow.DataBoundItem;
            FormModificar modificar = new FormModificar(seleccionado);
            modificar.ShowDialog();
            cargarGrilla();
        }

        public Articulos getCurrentArticulo()
        {
            Articulos seleccionado = (Articulos)dataGridViewPrincipal.CurrentRow.DataBoundItem;
            return seleccionado;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscar();
        }
        private void buscar()
        {
            List<Articulos> listaFiltrada;
            if (textBoxFiltrar.Text != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Descripcion.ToUpper().Contains(textBoxFiltrar.Text.ToUpper()) || x.Codigo.ToUpper().Contains(textBoxFiltrar.Text.ToUpper()) || x.Nombre.ToUpper().Contains(textBoxFiltrar.Text.ToUpper()) || x.Categoria.ToUpper().Contains(textBoxFiltrar.Text.ToUpper()) || x.Marca.ToUpper().Contains(textBoxFiltrar.Text.ToUpper()));
                dataGridViewPrincipal.DataSource = null;
                dataGridViewPrincipal.DataSource = listaFiltrada;
                dataGridViewPrincipal.Columns["ImagenUrl"].Visible = false;
            }
            else
            {
                dataGridViewPrincipal.DataSource = null;
                dataGridViewPrincipal.DataSource = listaArticulos;
                dataGridViewPrincipal.Columns["ImagenUrl"].Visible = false;
            }
        }
    }
}
