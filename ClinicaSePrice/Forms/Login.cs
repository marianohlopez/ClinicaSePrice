using ClinicaSePrice.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User? newUser = new User();

            //  Obtener data del formulario
            string inputName = txtUser.Text;
            string inputPass = txtPass.Text;

            newUser = User.LogUserIn(inputName, inputPass);

            // Validar nombre de usuario y contraseña
            if(newUser != null)
            {
                Home home = new Home(newUser.Username?? "", newUser.UserRole?? "");
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }
    }
}
