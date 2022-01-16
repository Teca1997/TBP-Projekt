using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APT
{
    public partial class MainForm : Form
    {  
        private StartForm startForm;
        private Stopwatch stopWatch;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(StartForm startForm)
        {
            InitializeComponent();
            Database.DohvatiSveSimptome();
            this.startForm = startForm;
            lblOsnovniPodatci.Text = "Prijavljeni ste kao " + Mama.ime + " " + Mama.prezime;
            lblZadnjiLogin.Text = "Početak sesije: " + Mama.zadnjiLogin.ToString("dd-MM-yyyy" + " HH:mm:ss");
            TimeSpan danaDoPoroda = Mama.terminPoroda - DateTime.Now;
            lblDaniDoTermina.Text = string.Format("Dana do termina poroda:: {0}", danaDoPoroda.Days);
            stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Show();
            Mama.id = 0;
            Database.AzurirajVrijemeLogout();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTrajanjeSesije.Text =string.Format("Trenutno trajanje sesije: {0:hh\\:mm\\:ss}", stopWatch.Elapsed);
        }

        private void btnSImptomi_Click(object sender, EventArgs e)
        {
            this.Hide();
            SimptomiForm simptomiForm = new SimptomiForm(this);
            simptomiForm.Show();
        }

        private void btnTrudovi_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrudoviForm trudoviForm = new TrudoviForm(this);
            trudoviForm.Show();
        }

        private void btnPomaci_Click(object sender, EventArgs e)
        {
            this.Hide();
            PomaciForm pomaciForm = new PomaciForm(this);
            pomaciForm.Show();
        }

        private void btnBiljeske_Click(object sender, EventArgs e)
        {
            this.Hide();
            BiljeskeForm biljeskeForm = new BiljeskeForm(this);
            biljeskeForm.Show();
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
