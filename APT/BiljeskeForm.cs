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
    public partial class BiljeskeForm : Form
    {
        MainForm mainForm;
        private DataTable biljeskeMameNaZadaniDatum;
        DateTime datum = DateTime.Now;
        public BiljeskeForm()
        {
            InitializeComponent();
        }

        public BiljeskeForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            txtBiljeska.Text = "Unesite bilješku";
            osvjeziDgv();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.ShowDialog();
        }

        private void osvjeziDgv()
        {
            biljeskeMameNaZadaniDatum = Database.DohvatiSveBiljeskeBMameNaDatum(datum);
            dgvBiljeske.DataSource = biljeskeMameNaZadaniDatum;
            if (dgvBiljeske.Columns.Count > 0)
            {
                dgvBiljeske.Columns[0].Visible = false;
                dgvBiljeske.Columns[1].Visible = false;
                dgvBiljeske.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvBiljeske.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void btnSpremiBiljesku_Click(object sender, EventArgs e)
        {
            Database.SpremiBilljesku(txtBiljeska.Text, datum);
            txtBiljeska.Text = "Unesite bilješku";
            txtBiljeska.ForeColor = Color.Gray;
            osvjeziDgv();
        }

        private void dtpDatumBiljeske_ValueChanged(object sender, EventArgs e)
        {
            datum = dtpDatumBiljeske.Value.Date;
            osvjeziDgv();
        }

        private void txtBiljeska_Enter(object sender, EventArgs e)
        {
            if (txtBiljeska.Text== "Unesite bilješku")
            {
                txtBiljeska.Clear();
                txtBiljeska.ForeColor = Color.Black;
            }
        }

        private void txtBiljeska_Leave(object sender, EventArgs e)
        {
            if (txtBiljeska.Text == "")
            {
                txtBiljeska.Text = "Unesite bilješku";
                txtBiljeska.ForeColor = Color.Gray;
            }
        }

        private void dgvBiljeske_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBiljeske.SelectedRows.Count == 0)
            {
                btnObrisi.Hide();
                btnOtvoriBiljesku.Hide();
            }
            else if (dgvBiljeske.SelectedRows.Count == 1)
            {
                btnObrisi.Text = "Obriši bilješku";
                btnObrisi.Show();
                btnOtvoriBiljesku.Show();
            } 
            else
            {
                btnObrisi.Text = "Obriši bilješke";
                btnObrisi.Show();
                btnOtvoriBiljesku.Hide();
            }
        }

        private void btnOtvoriBiljesku_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledBiljeskeForm pregledBiljeskeForm = new PregledBiljeskeForm(this, dgvBiljeske.SelectedRows[0].Cells[2].Value.ToString(), int.Parse(dgvBiljeske.SelectedRows[0].Cells[0].Value.ToString()));
            pregledBiljeskeForm.Show();
        }

        private void BiljeskeForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                osvjeziDgv();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow red in dgvBiljeske.SelectedRows)
            {
                Database.ObrisiBiljesku(int.Parse(red.Cells[0].Value.ToString()));
            }
            osvjeziDgv();
        }
    }
}
