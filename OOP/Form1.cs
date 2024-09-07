using OOP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private User _userManager;

        public Form1()
        {
            InitializeComponent();
            _userManager = new User();
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\user\\OneDrive\\Documents\\C# Log in\\OOP\\OOP\\oop.json");
            _userManager.LoadUsersFromJson(jsonFilePath);
            btnLogin.Click += new EventHandler(btnLogin_Click);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtusername.Text;    
            var password = txtpassword.Text;

            if (_userManager.IsValid(username, password))
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                label3.Text = "Invalid username or password.";
                label3.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}