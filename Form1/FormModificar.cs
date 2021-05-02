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
    public partial class FormModificar : Form
    {
        public  int ID { get; }

        public FormModificar(Articulos seleccionado)
        {
            InitializeComponent();
            ArticuloDB aux = new ArticuloDB();
            NegocioMarca negocioMarca = new NegocioMarca();
            NegocioCategoria negocioCategoria = new NegocioCategoria();
            ID = seleccionado.ID;
            aux.ID = seleccionado.ID;
            aux.Codigo = seleccionado.Codigo;
            aux.Nombre = seleccionado.Nombre;
            aux.ImagenURl = seleccionado.ImagenURl;
            aux.Descripcion = seleccionado.Descripcion;
            aux.Precio = seleccionado.Precio;

            string descripcionMarca = seleccionado.Marca;
            aux.IdMarca = getIDMarca(descripcionMarca);

            string descripcionCat = seleccionado.Categoria;
            aux.IdCategoria = getIDCat(descripcionCat);

            textBoxCod.Text = aux.Codigo;
            textBoxNombre.Text = aux.Nombre;
            textBoxDescripcion.Text = aux.Descripcion;
            textBoxURL.Text = aux.ImagenURl;
            numPrecio.Value = aux.Precio;  
          
            comboBoxMarca.DataSource = negocioMarca.listar();
            comboBoxMarca.SelectedIndex = aux.IdMarca -1;

            comboBoxCategoria.DataSource = negocioCategoria.listar();
            comboBoxCategoria.SelectedIndex = aux.IdCategoria-1;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAcepar_Click(object sender, EventArgs e)
        {
            NegocioArticulos negocioArticulos = new NegocioArticulos();
            ArticuloDB articulo = new ArticuloDB();
            ArticuloDB aux = new ArticuloDB();
            Articulos id = new Articulos();
            FormModificar IDSeleccionado = new FormModificar(id);

            try
            {
                //articulo.ID = IDSeleccionado.ID;
                articulo.ID = this.ID;
                articulo.Codigo = textBoxCod.Text;
                articulo.Nombre = textBoxNombre.Text;
                articulo.Descripcion = textBoxDescripcion.Text;

                aux.IdMarca = getIDMarca(comboBoxMarca.Text);
                articulo.IdMarca = aux.IdMarca;

                aux.IdCategoria = getIDCat(comboBoxCategoria.Text);
                articulo.IdCategoria = aux.IdMarca;

                articulo.ImagenURl = textBoxURL.Text;
                
                decimal precio = decimal.Parse(numPrecio.Value.ToString());
                articulo.Precio = precio;

                negocioArticulos.modificar(articulo);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private int getIDMarca(string descripcion)
        {
            List<Marca> lista = new List<Marca>();
            NegocioMarca marcaAux = new NegocioMarca();
            int idMarca = 0;

            lista = marcaAux.listar();

            for (var i = 0; i < lista.Count; i++)
            {
                if (lista[i].Descripcion == descripcion)
                {
                    idMarca = lista[i].ID;
                }
            }
            return idMarca;
        }

        private int getIDCat(string descripcion)
        {
            List<Categoria> lista = new List<Categoria>();
            NegocioCategoria catAux = new NegocioCategoria();
            int idCat = 0;

            lista = catAux.listar();

            for (var i = 0; i < lista.Count; i++)
            {
                if (lista[i].Descripcion == descripcion)
                {
                    idCat = lista[i].ID;
                }
            }
            return idCat;
        }
    }
}
