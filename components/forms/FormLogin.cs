using IdCard.Hanel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdCard.Hanel_obj.components.forms
{
    public partial class FormLogin : Form
    {
        private readonly UserRepository _userRepository = new(AuthenCardDbContext.Instance);


        public User? User { get; set; }


        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            var user = _userRepository.Login(txtUsername.Text, txtPwd.Text);
            if (user != null)
            {
                User = user;
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "Wrong username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
