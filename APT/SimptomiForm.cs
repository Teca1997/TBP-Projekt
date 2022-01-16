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
    public partial class SimptomiForm : Form
    {
        private MainForm mainForm;
        private DataTable simptomiMameNaZadaniDatum;
        public SimptomiForm()
        {
            InitializeComponent();
        }

        public SimptomiForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            foreach (string simptom in Simptom.simptomi)
            {
                clbSimptomi.Items.Add(simptom);
            }
            osvjeziDgv();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void btnDodajSimptome_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<clbSimptomi.Items.Count; i++)
            {
                if (clbSimptomi.GetItemCheckState(i)==CheckState.Checked || clbSimptomi.GetItemCheckState(i) == CheckState.Indeterminate)
                {
                    DateTime datum = dtpDatumSImptoma.Value.Date;
                    int id_simptoma = i+1;
                    Database.SpremiSimptomMame(datum, id_simptoma);
                }
                else
                {
                    for (int j=0; j< simptomiMameNaZadaniDatum.Rows.Count; j++)
                    {
                        if (simptomiMameNaZadaniDatum.Rows[j].ItemArray[0].ToString() == clbSimptomi.Items[i].ToString())
                        {
                            DateTime datum = dtpDatumSImptoma.Value.Date;
                            int id_simptoma = i + 1;
                            Database.ObrisiSimptomMame(datum, id_simptoma);
                        }
                    }
                }
            }
            osvjeziDgv();
        }

        private void dtpDatumSImptoma_ValueChanged(object sender, EventArgs e)
        {
            osvjeziDgv();
        }


        private void osvjeziDgv()
        {
            simptomiMameNaZadaniDatum = Database.DohvatiSveSimptomeMameNaDatum(dtpDatumSImptoma.Value.Date);
            dgvSImptomiMameNaDatum.DataSource = simptomiMameNaZadaniDatum;
            if (simptomiMameNaZadaniDatum.Rows.Count > 0)
            {
                dgvSImptomiMameNaDatum.Columns[2].Visible = false;
            }
            osvjeziClb();
        }

        private void osvjeziClb()
        {
            for (int j = 0; j < simptomiMameNaZadaniDatum.Rows.Count; j++)
            {
                int index = clbSimptomi.Items.IndexOf(simptomiMameNaZadaniDatum.Rows[j].ItemArray[0].ToString());
                clbSimptomi.SetItemCheckState(index, CheckState.Checked);
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
