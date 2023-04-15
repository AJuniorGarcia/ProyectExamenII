using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form
    {
        private ConexionBD conexionBD = new ConexionBD();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (conexionBD.ValidarUsuario(CodigoUsuarioTextBox.Text, ContraseñaTextBox.Text))
            {
                Menu formMenu = new Menu();
                formMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Intente de nuevo.");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CodigoUsuarioTextBox.Text == "")
            {
                errorProvider1.SetError(CodigoUsuarioTextBox, "Ingrese un usuario");
                return;
            }
            errorProvider1.Clear();
            if (ContraseñaTextBox.Text == "")
            {
                errorProvider1.SetError(ContraseñaTextBox, "Ingrese una contraseña");
                return;
            }
            errorProvider1.Clear();

            //Mandar al menu
            Menu menuFormulario = new Menu();
            this.Hide();
            menuFormulario.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            CodigoUsuarioTextBox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {

            if (ContraseñaTextBox.PasswordChar == '*')
            {
                ContraseñaTextBox.PasswordChar = '\0';
            }
            else
            {
                ContraseñaTextBox.PasswordChar = '*';
            }
        }
    }
}
