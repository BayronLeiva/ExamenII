using Conexion.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion.Clases
{
    public class ProductosAcceso
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examenunidadii; Uid=root; Pwd= Bayron200028;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable ListarProdcutos()
        {
            DataTable listaDT = new DataTable();

            try
            {
                string sql = "SELECT * FROM productos";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaDT.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
            return listaDT;
        }

        public bool InsertarProducto(Productos productos)
        {
            bool inserto = false;

            try
            {
                string sql = "INSERT INTO productos VALUES (@CodigoProducto, @Descripcion, @Precio, @Existencia);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CodigoProducto", productos.CodigoProducto);
                cmd.Parameters.AddWithValue("@Descripcion", productos.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", productos.Precio);
                cmd.Parameters.AddWithValue("@Existencia", productos.Existencia);

                cmd.ExecuteNonQuery();
                inserto = true;
                conn.Close();
            }
            catch (Exception)
            {

            }
            return inserto;
        }

        public bool ModificarProducto(Productos productos)
        {
            bool modifico = false;

            try
            {
                string sql = "UPDATE productos SET CodigoProducto = @CodigoProducto, Descripcion = @Descripcion, Precio = @Precio, Existencia = @Existencia WHERE Codigo = @Codigo;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Codigo", productos.CodigoProducto);
                cmd.Parameters.AddWithValue("@Descripcion", productos.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", productos.Precio);
                cmd.Parameters.AddWithValue("@Existencia", productos.Existencia);

                cmd.ExecuteNonQuery();
                modifico = true;
                conn.Close();
            }
            catch (Exception)
            {

            }
            return modifico;
        }

        public bool EliminarProducto(string codigo)
        {
            bool elimino = false;

            try
            {
                string sql = "DELETE FROM productos WHERE CodigoProducto = @CodigoProducto;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CodigoProducto", codigo);

                cmd.ExecuteNonQuery();
                elimino = true;
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            return elimino;
        }

        public Productos GetProductoPorCodigo(string codigo)
        {
            Productos productos = new Productos();

            try
            {
                string sql = "Select * from productos WHERE CodigoProducto = @CodigoProducto;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CodigoProducto", codigo);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    productos.CodigoProducto = Convert.ToInt32(reader["CodigoProducto"]);
                    productos.Descripcion = reader["Descripcion"].ToString();
                    productos.Precio = Convert.ToDecimal(reader["Precio"]);
                    productos.Existencia = Convert.ToInt32(reader["Existencia"]);
                }

            }
            catch (Exception)
            {
            }
            return productos;
        }

        public bool InsertarPedido(Pedidos pedidos)
        {
            bool inserto = false;

            try
            {
                string sql = "INSERT INTO pedidos VALUES (@CodigoPedido, @CodigoProducto, @Cliente, @Cantidad, @Subtotal, @ISV, @Total);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CodigoPedido", pedidos.CodigoPedido);
                cmd.Parameters.AddWithValue("@CodigoProducto", pedidos.CodigoProducto);
                cmd.Parameters.AddWithValue("@Cliente", pedidos.Cliente);
                cmd.Parameters.AddWithValue("@Cantidad", pedidos.Cantidad);
                cmd.Parameters.AddWithValue("@Subtotal", pedidos.SubTotal);
                cmd.Parameters.AddWithValue("@ISV", pedidos.ISV);
                cmd.Parameters.AddWithValue("@Total", pedidos.Total);

                cmd.ExecuteNonQuery();
                inserto = true;
                conn.Close();

            }
            catch (Exception)
            {

            }
            return inserto;
        }
    }
}
