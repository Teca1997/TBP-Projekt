
namespace APT
{
    partial class TrudoviForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrudoviForm));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.dgvTrudoviMameNaDatum = new System.Windows.Forms.DataGridView();
            this.dtpDatumTruda = new System.Windows.Forms.DateTimePicker();
            this.dtpVrijemeTruda = new System.Windows.Forms.DateTimePicker();
            this.txtTrajanjeTruda = new System.Windows.Forms.TextBox();
            this.lblTrajanjeTruda = new System.Windows.Forms.Label();
            this.btnAzurirajTrudove = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.cmbRazineBoli = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrudoviMameNaDatum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPovratak.Location = new System.Drawing.Point(622, 399);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(150, 50);
            this.btnPovratak.TabIndex = 5;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // dgvTrudoviMameNaDatum
            // 
            this.dgvTrudoviMameNaDatum.AllowUserToOrderColumns = true;
            this.dgvTrudoviMameNaDatum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrudoviMameNaDatum.Location = new System.Drawing.Point(12, 12);
            this.dgvTrudoviMameNaDatum.Name = "dgvTrudoviMameNaDatum";
            this.dgvTrudoviMameNaDatum.Size = new System.Drawing.Size(760, 229);
            this.dgvTrudoviMameNaDatum.TabIndex = 11;
            this.dgvTrudoviMameNaDatum.SelectionChanged += new System.EventHandler(this.dgvTrudoviMameNaDatum_SelectionChanged);
            // 
            // dtpDatumTruda
            // 
            this.dtpDatumTruda.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumTruda.Location = new System.Drawing.Point(26, 286);
            this.dtpDatumTruda.Name = "dtpDatumTruda";
            this.dtpDatumTruda.Size = new System.Drawing.Size(190, 20);
            this.dtpDatumTruda.TabIndex = 10;
            this.dtpDatumTruda.ValueChanged += new System.EventHandler(this.dtpDatumTruda_ValueChanged);
            // 
            // dtpVrijemeTruda
            // 
            this.dtpVrijemeTruda.Location = new System.Drawing.Point(26, 312);
            this.dtpVrijemeTruda.Name = "dtpVrijemeTruda";
            this.dtpVrijemeTruda.Size = new System.Drawing.Size(190, 20);
            this.dtpVrijemeTruda.TabIndex = 12;
            this.dtpVrijemeTruda.ValueChanged += new System.EventHandler(this.dtpVrijemeTruda_ValueChanged);
            // 
            // txtTrajanjeTruda
            // 
            this.txtTrajanjeTruda.Location = new System.Drawing.Point(167, 338);
            this.txtTrajanjeTruda.Name = "txtTrajanjeTruda";
            this.txtTrajanjeTruda.Size = new System.Drawing.Size(49, 20);
            this.txtTrajanjeTruda.TabIndex = 13;
            this.txtTrajanjeTruda.TextChanged += new System.EventHandler(this.txtTrajanjeTruda_TextChanged);
            // 
            // lblTrajanjeTruda
            // 
            this.lblTrajanjeTruda.AutoSize = true;
            this.lblTrajanjeTruda.Location = new System.Drawing.Point(23, 341);
            this.lblTrajanjeTruda.Name = "lblTrajanjeTruda";
            this.lblTrajanjeTruda.Size = new System.Drawing.Size(148, 13);
            this.lblTrajanjeTruda.TabIndex = 14;
            this.lblTrajanjeTruda.Text = "Trajanje truda (u sekundama):";
            // 
            // btnAzurirajTrudove
            // 
            this.btnAzurirajTrudove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAzurirajTrudove.Location = new System.Drawing.Point(466, 399);
            this.btnAzurirajTrudove.Name = "btnAzurirajTrudove";
            this.btnAzurirajTrudove.Size = new System.Drawing.Size(150, 50);
            this.btnAzurirajTrudove.TabIndex = 17;
            this.btnAzurirajTrudove.Text = "Ažuriraj trudove";
            this.btnAzurirajTrudove.UseVisualStyleBackColor = false;
            this.btnAzurirajTrudove.Click += new System.EventHandler(this.btnAzurirajTrudove_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnObrisi.Location = new System.Drawing.Point(310, 399);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(150, 50);
            this.btnObrisi.TabIndex = 18;
            this.btnObrisi.Text = "Obriši zapis";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // cmbRazineBoli
            // 
            this.cmbRazineBoli.FormattingEnabled = true;
            this.cmbRazineBoli.Items.AddRange(new object[] {
            "Neznatna",
            "Slaba",
            "Srednja",
            "Jaka",
            "Ekstremna"});
            this.cmbRazineBoli.Location = new System.Drawing.Point(26, 259);
            this.cmbRazineBoli.Name = "cmbRazineBoli";
            this.cmbRazineBoli.Size = new System.Drawing.Size(190, 21);
            this.cmbRazineBoli.TabIndex = 19;
            // 
            // TrudoviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::APT.Properties.Resources.logo_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.cmbRazineBoli);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnAzurirajTrudove);
            this.Controls.Add(this.lblTrajanjeTruda);
            this.Controls.Add(this.txtTrajanjeTruda);
            this.Controls.Add(this.dtpVrijemeTruda);
            this.Controls.Add(this.dgvTrudoviMameNaDatum);
            this.Controls.Add(this.dtpDatumTruda);
            this.Controls.Add(this.btnPovratak);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrudoviForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trudovi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrudoviMameNaDatum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.DataGridView dgvTrudoviMameNaDatum;
        private System.Windows.Forms.DateTimePicker dtpDatumTruda;
        private System.Windows.Forms.DateTimePicker dtpVrijemeTruda;
        private System.Windows.Forms.TextBox txtTrajanjeTruda;
        private System.Windows.Forms.Label lblTrajanjeTruda;
        private System.Windows.Forms.Button btnAzurirajTrudove;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ComboBox cmbRazineBoli;
    }
}