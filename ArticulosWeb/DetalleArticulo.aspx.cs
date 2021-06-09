using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
namespace ArticulosWeb
{
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            List<Articulos> listado = (List<Articulos>)Session["listadoArticulos"];
            Articulos seleccionado = listado.Find(x => x.ID == id);

            lblNombre.Text = seleccionado.Nombre;
            LblDescripcion.Text = seleccionado.Descripcion;
            ImageUrl.ImageUrl = seleccionado.ImagenURl;
            decimal aux =  seleccionado.Precio;
            LblPrecio.Text = aux.ToString();
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}