using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioArticulos
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try

            {
                datos.setearConsulta("SELECT A.id as ID, A.Codigo AS Codigo, A.ImagenUrl as Imagen, A.Nombre as Nombre, A.Descripcion as Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.Precio as Precio From Articulos as A, MARCAS AS M, CATEGORIAS AS C WHERE A.IdMarca= M.Id and A.IdCategoria=C.Id; ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.ID = (int)datos.Lector["ID"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.ImagenURl = (string)datos.Lector["Imagen"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = (string)datos.Lector["Marca"];
                    aux.Categoria = (string)datos.Lector["Categoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(ArticuloDB nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores ="values(" + "'" + nuevo.Codigo + "'" + ", '"+nuevo.Nombre+ "'" + ", '" +nuevo.Descripcion + "'" + ", " +nuevo.IdMarca + ", " +nuevo.IdCategoria+ ", '" + nuevo.ImagenURl + "'" + ","+ nuevo.Precio+")";
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenuRL, Precio)" + valores);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar (ArticuloDB nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta( "Update ARTICULOS SET Codigo= ' " + nuevo.Codigo + " ', nombre= ' " + nuevo.Nombre + " ', IdMarca= " + nuevo.IdMarca + ", IdCategoria= " + nuevo.IdCategoria + ", ImagenURL= ' " + nuevo.ImagenURl + "', Precio= '" + nuevo.Precio + " ' WHERE id= " + nuevo.ID + ")");
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From ARTICULOS Where Id = " + id);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();

            }

        }
    }
}
