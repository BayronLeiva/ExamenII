using Conexion.Clases;
using Conexion.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenII
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        Pedidos pedidos;
        Productos productos;
        ProductosAcceso productosAcceso = new ProductosAcceso();

        List<Pedidos>pedidosLista = new List<Pedidos>();

        decimal subTotal = 0;
        decimal isv = 0;
        decimal total = 0;

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            EventoLista();
        }

        private void EventoLista()
        {
            PedidosDGV.DataSource = pedidosLista;
        }

        private void CodigotextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CodigotextBox1.Text))
            {
                productos = new Productos();
                productos = productosAcceso.GetProductoPorCodigo(CodigotextBox1.Text);
                ProductotextBox1.Text = productos.Descripcion;
                ClientetextBox2.Focus();
            }
            else
            {
                productos = null;
                ProductotextBox1.Clear();
                ClientetextBox2.Clear();
                CantidadtextBox3.Clear();
            }
        }

        private void CantidadtextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadtextBox3.Text)) 
            {
                Pedidos pedidos = new Pedidos();
                
                subTotal = productos.Precio * pedidos.Cantidad;
                isv = subTotal * 0.15M;
                total = subTotal + isv;
                pedidos.Codigo = productos.Codigo;
                pedidos.Cliente = ClientetextBox2.Text;
                pedidos.Cantidad = Convert.ToInt32(CantidadtextBox3.Text);
                pedidos.SubTotal = subTotal;
                pedidos.ISV = isv;
                pedidos.Total = total;

                SubTotaltextBox4.Text = subTotal.ToString();
                ISVtextBox5.Text = isv.ToString();
                TotaltextBox6.Text = total.ToString();


                pedidosLista.Add(pedidos);
                PedidosDGV.DataSource = null;
                PedidosDGV.DataSource = pedidosLista;

                bool inserto = productosAcceso.InsertarPedido(pedidos);
                if (inserto)
                {
                    MessageBox.Show("El pedido fue realizado correctamente");
                    CodigotextBox1.Clear();
                    ClientetextBox2.Clear();
                    CantidadtextBox3.Clear();
                    SubTotaltextBox4.Clear();
                    ISVtextBox5.Clear();
                    TotaltextBox6.Clear();
                    ProductotextBox1.Clear();
                }
                else
                {
                    MessageBox.Show("El pedido no fue realizado");
                    CodigotextBox1.Clear();
                    ClientetextBox2.Clear();
                    CantidadtextBox3.Clear();
                    SubTotaltextBox4.Clear();
                    ISVtextBox5.Clear();
                    TotaltextBox6.Clear();
                    ProductotextBox1.Clear();
                }
            }
        }

        private void ClientetextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(ClientetextBox2.Text)) 
            { 
                CantidadtextBox3.Focus();
            }
            else if (e.KeyChar == (char)Keys.Enter && string.IsNullOrEmpty(ClientetextBox2.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente");
            }
        }
    }
}
