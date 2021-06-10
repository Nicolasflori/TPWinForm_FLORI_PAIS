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
    public partial class _Default : Page
    {
       public List<Articulos> lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioArticulos negocio = new NegocioArticulos();
            try
            {
                lista = negocio.listar();
                Session.Add("listadoArticulos", lista);
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            NegocioArticulos negocio = new NegocioArticulos();
            Articulos articulo = new Articulos();
            lista = negocio.listar();
            lista = lista.FindAll(x => x.Nombre.ToUpper().Contains(Request["search"].ToUpper()));
            Session.Add("listadoArticulos", lista);
        }
    }
}