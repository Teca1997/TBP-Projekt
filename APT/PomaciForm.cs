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
    public partial class PomaciForm : Form
    {
        MainForm mainForm;
        private DataTable pomaciMameNaZadaniDatum;
        DateTime datum = DateTime.Now;
        DateTime vrijeme = DateTime.Now;
        public PomaciForm()
        {
            InitializeComponent();
        }

        public PomaciForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            dtpVrijemePomaka.Format = DateTimePickerFormat.Custom;
            dtpVrijemePomaka.CustomFormat = "HH:mm:ss";
            dtpVrijemePomaka.ShowUpDown = true;

            osvjeziDgv();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.ShowDialog();
        }

        private void dtpDatumPomaka_ValueChanged(object sender, EventArgs e)
        {
            datum = dtpDatumPomaka.Value;
            osvjeziDgv();
        }

        private void dtpVrijemePomaka_ValueChanged(object sender, EventArgs e)
        {
            vrijeme = dtpVrijemePomaka.Value;
        }

        private void btnSpremiPomak_Click(object sender, EventArgs e)
        {
            Database.SpremiPomak(datum, vrijeme);
            osvjeziDgv();
        }


        private void osvjeziDgv()
        {
            pomaciMameNaZadaniDatum = Database.DohvatiSvePomakeMameNaDatum(dtpDatumPomaka.Value);
            dgvPomaciNaDatum.DataSource = pomaciMameNaZadaniDatum;
            if (dgvPomaciNaDatum.Columns.Count > 0)
            {
                dgvPomaciNaDatum.Columns[0].Visible = false;
                dgvPomaciNaDatum.Columns[2].Visible = false;
            }
            lblBrojPomakaNaDatum.Text = "Broj pomaka bebe: " + (dgvPomaciNaDatum.Columns.Count-1);
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

        private void btnObriši_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow red in dgvPomaciNaDatum.SelectedRows)
            {
                Database.ObrisiPomak(int.Parse(red.Cells[0].Value.ToString()));
            }
            osvjeziDgv();
        }

        private void dgvPomaciNaDatum_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPomaciNaDatum.SelectedRows.Count == 0)
            {
                btnObrisi.Hide();
            }
            else if (dgvPomaciNaDatum.SelectedRows.Count == 1)
            {
                btnObrisi.Text = "Obriši pomak";
                btnObrisi.Show();
            }
            else
            {
                btnObrisi.Text = "Obriši pomake";
                btnObrisi.Show();
            }
        }
    }
}
