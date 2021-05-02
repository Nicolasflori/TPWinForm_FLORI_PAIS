using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Form1
{
    public partial class FormVerDetalles : Form
    {
        public FormVerDetalles(Articulos seleccionado)
        {
            InitializeComponent();
            Lnombre.Text = seleccionado.Nombre;
            Ldesc.Text = seleccionado.Descripcion;
            Lcat.Text = seleccionado.Categoria;
            Lcodigo.Text = seleccionado.Codigo;
            Lmarca.Text = seleccionado.Marca;

            Lprecio.Text = Convert.ToString(seleccionado.Precio);

            try
            {
                PictureBoxDetalles.Load(seleccionado.ImagenURl);
            }
            catch (Exception)
            {
                PictureBoxDetalles.Load("https://www.freundferreteria.com/Productos/GetImagenProductoPrincipal?idProducto=f3d7edf5-20b4-4688-b6b2-ace3de7e219c&width=250&height=250&qa=75&ext=.jpg");
            }
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
