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
				datos.setearConsulta("SELECT A.id as ID, A.Codigo AS Codigo, A.ImagenUrl as Imagen, A.Nombre as Nombre, A.Descripcion as Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria From Articulos as A, MARCAS AS M, CATEGORIAS AS C where A.IdMarca= M.Id and A.IdCategoria=C.Id; ");
			  datos.ejecutarLectura();
				while(datos.Lector.Read())
                {
					Articulos aux = new Articulos();
					aux.ID = (int)datos.Lector["ID"];
					aux.Codigo = (string)datos.Lector["Codigo"];
					aux.ImagenURl = (string)datos.Lector["Imagen"];
					aux.Nombre = (string)datos.Lector["Nombre"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];
					//aux.Marca = (string)datos.Lector["Marca"];
					//aux.Categoria = (string)datos.Lector["Categoria"];

					lista.Add(aux);

				}
				return lista;
						}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{ datos.cerrarConexion();
			}
		}
	}
}
