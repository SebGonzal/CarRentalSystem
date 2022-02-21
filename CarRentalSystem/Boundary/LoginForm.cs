using System;
using System.ComponentModel;
using System.Windows.Forms;
using CarRentalSystem.Controllers;

namespace CarRentalSystem.Boundary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usr = usrnamebox.Text;
            string pwd = pswdbox.Text;
            if (LoginControl.Login(usr, pwd))
            {
                this.Hide();
            }
            else
            {
                DisplayError();
            }
        }
        public void DisplayError()
        {
            string message = "Incorrect Username or Password";
            string caption = "Input Error";
            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult ErrMessage = MessageBox.Show(message, caption, button);
        }
        //private void textBox1_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(textBox1.Text))
        //    {
        //        e.Cancel = true;
        //        textBox1.Focus();
        //        errorProvider1.SetError(textBox1, "Username should not be left blank!");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProvider1.SetError(textBox1, "");
        //    }
        //}
        //private void textBox2_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(textBox2.Text))
        //    {
        //        e.Cancel = true;
        //        textBox2.Focus();
        //        errorProvider1.SetError(textBox2, "Password should not be left blank!");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProvider1.SetError(textBox2, "");
        //    }
        //}
        public void CleanForm()
        {
            usrnamebox.Text = String.Empty;
            pswdbox.Text = String.Empty;
            usrnamebox.Focus();
        }
        private void Loginform_Load(object sender, EventArgs e)
        {
        }
        private void usrnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string usr = usrnamebox.Text;
                string pwd = pswdbox.Text;
                e.SuppressKeyPress = true;
                e.Handled = true;
                if (LoginControl.Login(usr, pwd))
                {
                    this.Hide();
                }
                else
                {
                    DisplayError();
                }
            }
        }
        private void usrname_TextChanged(object sender, EventArgs e)
        {
        }
        private void pswdbox_TextChanged(object sender, EventArgs e)
        {
        }
        private void pswdtxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string usr = usrnamebox.Text;
                string pwd = pswdbox.Text;
                e.SuppressKeyPress = true;
                e.Handled = true;
                if (LoginControl.Login(usr, pwd))
                {
                    this.Hide();
                }
                else
                {
                    DisplayError();
                }
            }
        }
    }
}