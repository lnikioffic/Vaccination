using Lab6new.Controllers;
using Lab6new.Controllers.Interface;
using Lab6new.Models;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6new.Forms
{
    public partial class AuthForm : Form
    {

        private IAuthController authController = new AuthController();

        public AuthForm()
        {
            InitializeComponent();
            var permMan = authController.Authorization("admin", "admin");
            var registriesListForm = new RegistriesListForm(permMan);
            this.Hide();
            registriesListForm.Show();

        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;
            try
            {
                var permMan = authController.Authorization(login, password);
                var registriesListForm = new RegistriesListForm(permMan);
                registriesListForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                errorsLabel.Text = ex.Message;
            }

        }
    }
}
