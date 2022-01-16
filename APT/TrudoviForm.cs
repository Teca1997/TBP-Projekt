using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APT
{
    public partial class TrudoviForm : Form
    {

        private MainForm mainForm;
        private DataTable trudoviMameNaZadaniDatum;
        DateTime datum = DateTime.Now;
        DateTime vrijeme = DateTime.Now;
        public TrudoviForm()
        {
            InitializeComponent();
        }

        public TrudoviForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            dtpVrijemeTruda.Format = DateTimePickerFormat.Custom;
            dtpVrijemeTruda.CustomFormat = "HH:mm:ss";
            dtpVrijemeTruda.ShowUpDown = true;
            /*
            dtpVrijemeTruda.Format = DateTimePickerFormat.Time;
            dtpVrijemeTruda.ShowUpDown = true;
            */
            txtTrajanjeTruda.Text = "0";

            osvjeziDgv();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.ShowDialog();
        }

        private void btnAzurirajTrudove_Click(object sender, EventArgs e)
        {
            int razinaBoli = cmbRazineBoli.SelectedIndex + 1;
            if (razinaBoli > 0)
            {
                Database.SpremiTrud(razinaBoli,  datum.ToString(), vrijeme.ToString(), int.Parse(txtTrajanjeTruda.Text));
                osvjeziDgv();
            } else
            {
                MessageBox.Show("Odaberite razinu boli.");
            }
            
        }


        private void txtTrajanjeTruda_TextChanged(object sender, EventArgs e)
        {
            if (txtTrajanjeTruda.Text == "")
            {
                txtTrajanjeTruda.Text = "0";
            }
        }

        private void dtpDatumTruda_ValueChanged(object sender, EventArgs e)
        {
            datum = dtpDatumTruda.Value;
            osvjeziDgv();
        }

        private void dtpVrijemeTruda_ValueChanged(object sender, EventArgs e)
        {
            vrijeme = dtpVrijemeTruda.Value;
        }

        private void osvjeziDgv()
        {
            trudoviMameNaZadaniDatum = Database.DohvatiSveTrudoveMameNaDatum(datum);
            dgvTrudoviMameNaDatum.DataSource = trudoviMameNaZadaniDatum;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvTrudoviMameNaDatum.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvTrudoviMameNaDatum.SelectedRows[0].Cells["id"].Value.ToString());
                Database.ObrisiTrud(id);
                osvjeziDgv();
            }
        }

        private void dgvTrudoviMameNaDatum_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTrudoviMameNaDatum.SelectedRows.Count == 1)
            {
                btnObrisi.Show();
            }
            else
            {
                btnObrisi.Hide();
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
