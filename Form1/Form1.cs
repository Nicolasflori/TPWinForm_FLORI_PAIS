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
using System.Data.SqlClient;
namespace Form1
{
    public partial class Form1 : Form
    {
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
                dataGridViewPrincipal.DataSource = negocio.listar();
                dataGridViewPrincipal.Columns["ImagenUrl"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
