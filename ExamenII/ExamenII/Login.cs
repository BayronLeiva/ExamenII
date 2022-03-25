using Conexion.Clases;
using Conexion.Entidades;
using System;
using System.Windows.Forms;

namespace ExamenII
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            UsuariosAcceso usuarioAcceso = new UsuariosAcceso();
            Usuarios usuario = new Usuarios();

            usuario = usuarioAcceso.Login(textBoxCodigo.Text, textBoxContraseña.Text);

            if (usuario == null)
            {
                MessageBox.Show("El usuario no existe");
                return;
            }

            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
