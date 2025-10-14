using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanGithub
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            {
                string username = txtuser.Text;
                string password = txtpass.Text;

                // Contoh login sederhana (hardcode)
                if (username == "admin" && password == "123")
                {
                    MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Contoh: buka form utama setelah login
                    FormMenu formLogin = new FormMenu();
                    formLogin.Show();
                    this.Hide(); // sembunyikan form loginn
                }
                else
                {
                    MessageBox.Show("Username atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuser.Focus();
                }
            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            // Bersihkan input
            txtuser.Clear();
            txtpass.Clear();
            txtuser.Focus();
        }
    }
}
