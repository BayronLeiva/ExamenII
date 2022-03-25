using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion.Entidades
{
    public class Productos
    {
        public int CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }

        public Productos()
        {
        }

        public Productos(int codigo, string descripcion, decimal precio, int existencia)
        {
            CodigoProducto = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Existencia = existencia;
        }
    }
}
