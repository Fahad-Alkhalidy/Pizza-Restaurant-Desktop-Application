using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool checkEmail = txtEmail.Text.Equals(txtEmail.Tag);
            bool checkPassword = txtPassword.Text.Equals(txtPassword.Tag);

           // if(checkEmail && checkPassword)
            //{
                 Form form = new PizzaMenu();
                form.ShowDialog();
           // }
          //  else
          //  {
           //     MessageBox.Show("Your Information Is Incorrect!!!", "Incorrect Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
