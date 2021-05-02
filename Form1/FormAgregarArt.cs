﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Form1
{
    public partial class FormAgregarArt : Form
    {
       
        public FormAgregarArt()
        {
            InitializeComponent();
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void FormAgregarArt_Load(object sender, EventArgs e)
        {
            NegocioMarca negocioMarca = new NegocioMarca();
            NegocioCategoria negocioCategoria = new NegocioCategoria();
            try
            {
                comboBoxMarca.DataSource = negocioMarca.listar();
                comboBoxCategoria.DataSource = negocioCategoria.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            NegocioArticulos negocioArticulos = new NegocioArticulos();
            
            NegocioCategoria catAux = new NegocioCategoria();
            ArticuloDB articulo = new ArticuloDB();
            ArticuloDB aux = new ArticuloDB();

            try
            {       
                articulo.Codigo = textBoxCod.Text;
                articulo.Nombre = textBoxNombre.Text;
                articulo.Descripcion = textBoxDescripcion.Text;

                aux.IdMarca = getIDMarca(comboBoxMarca.Text);
                articulo.IdMarca = aux.IdMarca;

                aux.IdCategoria = getIDCat(comboBoxCategoria.Text);
                articulo.IdCategoria = aux.IdMarca;
                articulo.ImagenURl = textBoxURL.Text;

                decimal precio = decimal.Parse(textBoxPrecio.Text);
                articulo.Precio = precio;

                negocioArticulos.agregar(articulo);
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
