namespace Conexion.Entidades
{
    public class Usuarios
    {
        public string CodigoUsuario { get; set; }

        public string Contraseña { get; set; }

        public Usuarios()
        {
        }

        public Usuarios(string codigoUsuario, string contraseña)
        {
            CodigoUsuario = codigoUsuario;
            Contraseña = contraseña;
        }
    }
}
