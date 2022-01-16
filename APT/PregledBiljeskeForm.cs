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
    public partial class PregledBiljeskeForm : Form
    {
        BiljeskeForm biljeskeForm;
        string biljeska;
        int id_biljeske;
        public PregledBiljeskeForm()
        {
            InitializeComponent();
        }

        public PregledBiljeskeForm(BiljeskeForm biljeskeForm, string biljeska, int id_biljeske)
        {
            InitializeComponent();
            this.biljeskeForm = biljeskeForm;
            this.biljeska = biljeska;
            this.id_biljeske = id_biljeske;
            txtBiljeska.Text = this.biljeska;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
            biljeskeForm.Show();
        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {
            Database.AzurirajBiljesku(id_biljeske, txtBiljeska.Text);
            this.Close();
            biljeskeForm.ShowDialog();
        }

        private void txtBiljeska_TextChanged(object sender, EventArgs e)
        {
            if (txtBiljeska.Text == biljeska)
            {
                btnSpremiPromjene.Hide();
            }
            else
            {
                btnSpremiPromjene.Show();
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
