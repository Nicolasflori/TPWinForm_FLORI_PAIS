﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
     public class Categoria
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public Categoria (int id, string descripcion)
        {
            ID = id;
            Descripcion = descripcion;

        }
    }
}
