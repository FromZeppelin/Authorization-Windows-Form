using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorizationForm
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        private void Authorizate_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Login" && PasswordBox.Text == "Password")
            {
                MessageBox.Show("Вы успешно авторизованы.");
                Application.Exit();
            }
            else if (LoginBox.Text == "" && PasswordBox.Text == "" || LoginBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("Вы не ввели логин и/или пароль.");
            }
            else
            {
                MessageBox.Show("Неверный логин и/или пароль.");
                Form Captcha = new Captcha();
                Captcha.Show();
                this.Hide();
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
