using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            userTextBox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text == "rawan" && passwordTextBox.Text == "1234")
            {
                main_menu form1 = new main_menu();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password you entered is incorrect, try again!");
                userTextBox.Clear();
                passwordTextBox.Clear();
                userTextBox.Focus();
            }




           
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

       
    }
}
