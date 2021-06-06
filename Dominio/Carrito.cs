using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Carrito
    {
       
        public List<ItemCarrito> Items { get; set; }
    }

    public class ItemCarrito
    {
        public int Cantidad { get; set; }
        public Articulos Articulos { get; set; }
        public double SubTotal { get; set; }
    }
}
