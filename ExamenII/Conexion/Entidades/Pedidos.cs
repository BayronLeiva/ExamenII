using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion.Entidades
{
    public class Pedidos
    {
        public int Codigo { get; set; }

        public string Cliente { get; set; }

        public int Cantidad { get; set; }

        public decimal SubTotal { get; set; }

        public decimal ISV { get; set; }

        public decimal Total { get; set; }

        public Pedidos()
        {
        }

        public Pedidos(int codigo, string cliente, int cantidad, decimal subTotal, decimal iSV, decimal total)
        {
            Codigo = codigo;
            Cliente = cliente;
            Cantidad = cantidad;
            SubTotal = subTotal;
            ISV = iSV;
            Total = total;
        }
    }
}
