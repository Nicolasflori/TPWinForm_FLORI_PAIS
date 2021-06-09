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
    public partial class CarritoDeCompras : System.Web.UI.Page
    {
        public List<ItemCarrito> carrito;

        public ItemCarrito elemento;

        protected void Page_Load(object sender, EventArgs e)

        {
            elemento = new ItemCarrito();
            carrito = (List<ItemCarrito>)Session["listaCarrito"];

            if (carrito == null)
                carrito = new List<ItemCarrito>();

            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    if (carrito.Find(x => x.Articulos.ID.ToString() == Request.QueryString["id"]) == null)
                    {
                        List<Articulos> listadoOriginal = (List<Articulos>)Session["listadoArticulos"];
                        elemento.Cantidad++;
                        elemento.Articulos = listadoOriginal.Find(x => x.ID.ToString() == Request.QueryString["id"]);
                        carrito.Add(elemento);
                    }
                }
                else if (Request.QueryString["id"] == "atras")
                {
                    Response.Redirect(default);
                }
                Repetidor.DataSource = carrito;

                Repetidor.DataBind();
            }
            Session.Add("ListaCarrito", carrito);
        }

        protected void buttonEliminar_Click(object sender, EventArgs e)
        {
            try

            {



                var argument = ((Button)sender).CommandArgument;



                List<ItemCarrito> carrito = (List<ItemCarrito>)Session["listaCarrito"];

                ItemCarrito elim = carrito.Find(x => x.Articulos.ID.ToString() == argument);

                carrito.Remove(elim);

                Session.Add("listaFavoritos", carrito);

                Repetidor.DataSource = null;

                Repetidor.DataSource = carrito;

                Repetidor.DataBind();



            }

            catch (Exception ex)

            {

                Response.Redirect("Error.aspx");

            }
        }
    }
}