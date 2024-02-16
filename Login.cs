using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimpleTextEditorApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loginSuccessful = false;
            string[] users = File.ReadAllLines("login.txt");
            foreach (string user in users)
            {
                string[] separator = { ",", " " };
                string[] userInfo = user.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if (txtUsername.Text == userInfo[0] && txtPassword.Text == userInfo[1])
                {
                    loginSuccessful = true;
                    Hide();
                    new TextEditor(this, $"{userInfo[3]} {userInfo[4]}", userInfo[2]).Show();
                    break;
                }
            }
            if (!loginSuccessful)
                MessageBox.Show("Incorrect username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPassword.Text = string.Empty;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            Hide();
            new NewUser(this).Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
