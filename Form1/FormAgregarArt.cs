using System;
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
            try
            {
                comboBoxMarca.DataSource = negocioMarca.listar();
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
    }
}
