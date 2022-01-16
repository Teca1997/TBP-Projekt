using Npgsql;
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
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
        }

        private StartForm startForm;
        public RegisterForm(StartForm startForm)
        {
            InitializeComponent();
            this.startForm = startForm;
            btnToggleLozinka.Enabled = false;
            btnToggleLozinkaPonovljena.Enabled = false;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Show();
        }

        private void txtBoxIme_Enter(object sender, EventArgs e)
        {
            if (txtBoxIme.Text == "Ime")
            {
                txtBoxIme.Text = "";
            }
        }

        private void txtBoxIme_Leave(object sender, EventArgs e)
        {
            if (txtBoxIme.Text == "")
            {
                txtBoxIme.Text = "Ime";
            }
        }

        private void txtBoxPrezime_Enter(object sender, EventArgs e)
        {
            if (txtBoxPrezime.Text == "Prezime")
            {
                txtBoxPrezime.Text = "";
            }
        }

        private void txtBoxPrezime_Leave(object sender, EventArgs e)
        {
            if (txtBoxPrezime.Text == "")
            {
                txtBoxPrezime.Text = "Prezime";
            }
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

        private void txtBoxLozinkaPonovljena_Enter(object sender, EventArgs e)
        {
            if (txtBoxLozinkaPonovljena.Text == "Ponovite lozinku")
            {
                txtBoxLozinkaPonovljena.Text = "";
                txtBoxLozinkaPonovljena.PasswordChar = '*';
            }
        }

        private void txtBoxLozinkaPonovljena_Leave(object sender, EventArgs e)
        {
            if (txtBoxLozinkaPonovljena.Text == "")
            {
                txtBoxLozinkaPonovljena.PasswordChar = (char)0;
                txtBoxLozinkaPonovljena.Text = "Ponovite lozinku";

            }
        }

        private void txtBoxLozinka_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxLozinka.Text =="Lozinka" || txtBoxLozinka.Text == "")
            {
                btnToggleLozinka.Enabled = false;
            }
            else
            {
                btnToggleLozinka.Enabled = true;
            }
        }

        private void txtBoxLozinkaPonovljena_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxLozinkaPonovljena.Text == "Lozinka" || txtBoxLozinkaPonovljena.Text == "")
            {
                btnToggleLozinkaPonovljena.Enabled = false;
            }
            else
            {
                btnToggleLozinkaPonovljena.Enabled = true;
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

        private void btnToggleLozinkaPonovljena_Click(object sender, EventArgs e)
        {
            if (txtBoxLozinkaPonovljena.PasswordChar == '*')
            {
                txtBoxLozinkaPonovljena.PasswordChar = (char)0;
            }
            else
            {
                txtBoxLozinkaPonovljena.PasswordChar = '*';
            }
        }

        private void btnRegistrairajSe_Click(object sender, EventArgs e)
        {
            if (txtBoxLozinka.Text == txtBoxLozinkaPonovljena.Text)
            {
                string ime = txtBoxIme.Text;
                string prezime = txtBoxPrezime.Text;
                string email = txtBoxEmail.Text;
                string lozinka = txtBoxLozinka.Text;
                DateTime terminPoroda = dtpTerminPoroda.Value.Date;
                string saltLozinka = EnkripcijaLozinke.GenerateSalt();
                string hashLozinka = EnkripcijaLozinke.GenerateSaltedHash(lozinka, saltLozinka);
                try
                {
                    Database.RegistrirajSe(ime, prezime, email, hashLozinka, terminPoroda);
                    MessageBox.Show("Registracija uspješna!");
                    this.Close();
                    startForm.Show();
                }
                catch (PostgresException ex)
                {

                    MessageBox.Show(ex.MessageText);
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
        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
