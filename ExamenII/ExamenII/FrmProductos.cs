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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        string operacion = string.Empty;
        ProductosAcceso productoDA = new ProductosAcceso();

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void ListarProductos()
        {
            ProductosDWV.DataSource = productoDA.ListarProdcutos();
        }

        private void HabilitarControles()
        {
            textBoxCodigo.Enabled = true;
            textBoxDescripcion.Enabled = true;
            textBoxPrecio.Enabled = true;
            textBoxExistencia.Enabled = true;
            buttonGuardar.Enabled = true;
            buttonNuevo.Enabled = false;
            buttonModificar.Enabled = false;
        }

        private void DesHabilitarControles()
        {
            textBoxCodigo.Enabled = false;
            textBoxDescripcion.Enabled = false;
            textBoxPrecio.Enabled = false;
            textBoxExistencia.Enabled = false;
            buttonGuardar.Enabled = false;
            buttonNuevo.Enabled = true;
            buttonModificar.Enabled = true;
        }

        private void LimpiarControles()
        {
            textBoxCodigo.Clear();
            textBoxDescripcion.Clear();
            textBoxPrecio.Clear();
            textBoxExistencia.Clear();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxCodigo.Text))
                {
                    errorProvider1.SetError(textBoxCodigo, "Ingrese el codigo");
                    textBoxCodigo.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(textBoxDescripcion.Text))
                {
                    errorProvider1.SetError(textBoxDescripcion, "Ingrese una descripcion");
                    textBoxDescripcion.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(textBoxPrecio.Text))
                {
                    errorProvider1.SetError(textBoxPrecio, "Ingrese un precio");
                    textBoxPrecio.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(textBoxExistencia.Text))
                {
                    errorProvider1.SetError(textBoxExistencia, "Ingrese la existencia");
                    textBoxExistencia.Focus();
                    return;
                }

                Productos productos = new Productos();

                productos.CodigoProducto = Convert.ToInt32(textBoxCodigo.Text);
                productos.Descripcion = textBoxDescripcion.Text;
                productos.Precio = Convert.ToDecimal(textBoxPrecio.Text);
                productos.Existencia = Convert.ToInt32(textBoxExistencia.Text);

                if (operacion == "Nuevo")
                {
                    bool inserto = productoDA.InsertarProducto(productos);

                    if (inserto)
                    {
                        DesHabilitarControles();
                        LimpiarControles();
                        ListarProductos();
                        MessageBox.Show("El producto fue ingresado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("El producto no fue ingresado");
                    }
                }
                else if (operacion == "Modificar")
                {
                    bool modifico = productoDA.ModificarProducto(productos);
                    if (modifico)
                    {
                        LimpiarControles();
                        DesHabilitarControles();
                        ListarProductos();
                        MessageBox.Show("Producto Modificado");
                    }
                    else
                    {
                        MessageBox.Show("Producto no modificado");
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (ProductosDWV.SelectedRows.Count > 0)
            {
                textBoxCodigo.Text = ProductosDWV.CurrentRow.Cells["Codigo"].Value.ToString();
                textBoxDescripcion.Text = ProductosDWV.CurrentRow.Cells["Descripcion"].Value.ToString();
                textBoxPrecio.Text = ProductosDWV.CurrentRow.Cells["Precio"].Value.ToString();
                textBoxExistencia.Text = ProductosDWV.CurrentRow.Cells["Existencia"].Value.ToString();


                HabilitarControles();
                textBoxCodigo.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (ProductosDWV.SelectedRows.Count > 0)
            {
                bool elimino = productoDA.EliminarProducto(ProductosDWV.CurrentRow.Cells["Codigo"].Value.ToString());

                if (elimino)
                {
                    ListarProductos();
                    MessageBox.Show("El producto ha sido eliminado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El producto no se pudo eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxCodigo, "Ingrese un caracter numerico");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
