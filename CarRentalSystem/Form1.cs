﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystem.Controllers;

namespace CarRentalSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usr = textBox1.Text;
            string pwd = textBox2.Text;
            LoginControl.Login(usr, pwd);
        }
        public void DisplayError()
        {
            string message = "Incorrect Username or Password";
            string caption = "Input Error";
            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult ErrMessage = MessageBox.Show(message, caption, button);
            if (ErrMessage == DialogResult.OK)
            {
                // Need to find out how to close
            }
        }
    }
}
