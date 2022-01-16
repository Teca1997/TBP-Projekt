using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APT
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private StartForm startForm;
        public LoginForm(StartForm startForm)
        {
            InitializeComponent();
            this.startForm = startForm;
            btnToggleLozinka.Enabled = false;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Show();
        }

        private void txtBoxEmail_Enter(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text == "Email")
            {
                txtBoxEmail.Text = "";
            } 
        }

        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text == "")
            {
                txtBoxEmail.Text = "Email";
            }
        }

        private void txtBoxLozinka_Enter(object sender, EventArgs e)
        {
            if (txtBoxLozinka.Text == "Lozinka")
            {
                txtBoxLozinka.Text = "";
                txtBoxLozinka.PasswordChar = '*';
            }
        }

        private void txtBoxLozinka_Leave(object sender, EventArgs e)
        {
            if (txtBoxLozinka.Text == "")
            {
                txtBoxLozinka.PasswordChar = (char)0;
                txtBoxLozinka.Text = "Lozinka";
                
            }
        }

        private void btnToggleLozinka_Click(object sender, EventArgs e)
        {
            if (txtBoxLozinka.PasswordChar == '*')
            {
                txtBoxLozinka.PasswordChar = (char)0;
            }
            else
            {
                txtBoxLozinka.PasswordChar = '*';
            }
        }

        private void txtBoxLozinka_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxLozinka.Text == "Lozinka" || txtBoxLozinka.Text == "")
            {
                btnToggleLozinka.Enabled = false;
            }
            else
            {
                btnToggleLozinka.Enabled = true;
            }
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if (txtBoxLozinka.Text != "" && txtBoxLozinka.Text != "Lozinka" && txtBoxEmail.Text != "" && txtBoxEmail.Text != "Email")
            {
                if (Database.PrijaviSe(txtBoxEmail.Text, txtBoxLozinka.Text)){
                    MainForm mainForm = new MainForm(this.startForm);
                    this.Close();
                    mainForm.Show();
                    Database.SpremiNoviLogin();
                }
                else
                {
                    MessageBox.Show("Neispravni podatci! Molim pokušajte ponovno.");
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 161;
            const int WM_SYSCOMMAND = 274;
            const int HTCAPTION = 2;
            const int SC_MOVE = 61456;
            if ((m.Msg == WM_SYSCOMMAND) && (m.WParam.ToInt32() == SC_MOVE))
                return;
            if ((m.Msg == WM_NCLBUTTONDOWN) && (m.WParam.ToInt32() == HTCAPTION)
            )
                return;
            base.WndProc(ref m);
        }
    }

}
