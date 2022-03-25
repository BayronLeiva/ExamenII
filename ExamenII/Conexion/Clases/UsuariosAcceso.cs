using Conexion.Entidades;
using MySql.Data.MySqlClient;
using System;

namespace Conexion.Clases
{
    public class UsuariosAcceso
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examenii; Uid=root; Pwd= Bayron200028;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuarios Login(string codigoUsuario, string contraseña)
        {
            Usuarios usuario = new Usuarios();

            try
            {
                string sql = "SELECT * FROM usuarios WHERE CodigoUsuario = @CodigoUsuario AND Contraseña = @Contraseña;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);
                cmd.Parameters.AddWithValue("Contraseña", contraseña);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usuario = new Usuarios();
                    usuario.CodigoUsuario = reader[0].ToString();
                    usuario.Contraseña = reader[1].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
            return usuario;
        }
    }
}
