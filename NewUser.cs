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
    public partial class NewUser : Form
    {
        Login login;

        public NewUser(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            this.dtpDOB.CustomFormat = "dd-MM-yyyy";
            dtpDOB.MaxDate = DateTime.Today;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("Name cannot be blank.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtUsername.Text == "" )
            {
                MessageBox.Show("Username cannot be blank.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (UsernameExists(txtUsername.Text))
            {
                MessageBox.Show("Username already exists.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtPassword.Text == "" || txtReenterPass.Text == "")
            {
                MessageBox.Show("Password cannot be blank.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtPassword.Text != txtReenterPass.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (comboUserType.SelectedItem == null) 
            {
                MessageBox.Show("Please select user type.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                File.AppendAllText("login.txt", $"\n{txtUsername.Text},{txtPassword.Text}," +
                    $"{comboUserType.SelectedItem},{txtFirstName.Text},{txtLastName.Text}," +
                    $"{dtpDOB.Text}");
                MessageBox.Show("Account successfully created.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                login.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            login.Show();
        }

        private bool UsernameExists(string username)
        {
            string[] users = File.ReadAllLines("login.txt");
            foreach (string user in users)
            {
                string[] separator = { ",", " " };
                string[] userInfo = user.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if (username == userInfo[0])
                    return true;
            }
            return false;
        }
    }
}
