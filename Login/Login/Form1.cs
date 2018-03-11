using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            Button ShowHide = sender as Button;
            if(ShowHide.Text == "Show")
            {
                ShowHide.Text = "Hide";
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                ShowHide.Text = "Show";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;

            // LowerCase Check
            if (pass.Any(char.IsLower))
            {
                lblLowerCase.ForeColor = Color.Gray;
            }
            else
            {
                lblLowerCase.ForeColor = SystemColors.ControlText;
            }

            // UpperCase Check
            if (pass.Any(char.IsUpper))
            {
                lblUpperCase.ForeColor = Color.Gray;
            }
            else
            {
                lblUpperCase.ForeColor = SystemColors.ControlText;
            }

            // Special Character Check
            if (pass.Any(char.IsPunctuation))
            {
                lblSpecChar.ForeColor = Color.Gray;
            }
            else
            {
                lblSpecChar.ForeColor = SystemColors.ControlText;
            }

            // Number Check
            if (pass.Any(char.IsDigit))
            {
                lblNum.ForeColor = Color.Gray;
            }
            else
            {
                lblNum.ForeColor = SystemColors.ControlText;
            }

            // 8 Characters Check
            if (pass.Length >= 8)
            {
                lbl8min.ForeColor = Color.Gray;
            }
            else
            {
                lbl8min.ForeColor = SystemColors.ControlText;
            }
        }
    }
}
