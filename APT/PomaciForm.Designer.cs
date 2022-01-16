
namespace APT
{
    partial class PomaciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PomaciForm));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.dtpVrijemePomaka = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumPomaka = new System.Windows.Forms.DateTimePicker();
            this.btnSpremiPomak = new System.Windows.Forms.Button();
            this.dgvPomaciNaDatum = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblBrojPomakaNaDatum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPomaciNaDatum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPovratak.Location = new System.Drawing.Point(618, 395);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(150, 50);
            this.btnPovratak.TabIndex = 5;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // dtpVrijemePomaka
            // 
            this.dtpVrijemePomaka.Location = new System.Drawing.Point(34, 293);
            this.dtpVrijemePomaka.Name = "dtpVrijemePomaka";
            this.dtpVrijemePomaka.Size = new System.Drawing.Size(190, 20);
            this.dtpVrijemePomaka.TabIndex = 14;
            this.dtpVrijemePomaka.ValueChanged += new System.EventHandler(this.dtpVrijemePomaka_ValueChanged);
            // 
            // dtpDatumPomaka
            // 
            this.dtpDatumPomaka.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumPomaka.Location = new System.Drawing.Point(34, 267);
            this.dtpDatumPomaka.Name = "dtpDatumPomaka";
            this.dtpDatumPomaka.Size = new System.Drawing.Size(190, 20);
            this.dtpDatumPomaka.TabIndex = 13;
            this.dtpDatumPomaka.ValueChanged += new System.EventHandler(this.dtpDatumPomaka_ValueChanged);
            // 
            // btnSpremiPomak
            // 
            this.btnSpremiPomak.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSpremiPomak.Location = new System.Drawing.Point(462, 395);
            this.btnSpremiPomak.Name = "btnSpremiPomak";
            this.btnSpremiPomak.Size = new System.Drawing.Size(150, 50);
            this.btnSpremiPomak.TabIndex = 15;
            this.btnSpremiPomak.Text = "Spremi pomak";
            this.btnSpremiPomak.UseVisualStyleBackColor = false;
            this.btnSpremiPomak.Click += new System.EventHandler(this.btnSpremiPomak_Click);
            // 
            // dgvPomaciNaDatum
            // 
            this.dgvPomaciNaDatum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPomaciNaDatum.Location = new System.Drawing.Point(12, 12);
            this.dgvPomaciNaDatum.Name = "dgvPomaciNaDatum";
            this.dgvPomaciNaDatum.Size = new System.Drawing.Size(756, 249);
            this.dgvPomaciNaDatum.TabIndex = 16;
            this.dgvPomaciNaDatum.SelectionChanged += new System.EventHandler(this.dgvPomaciNaDatum_SelectionChanged);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnObrisi.Location = new System.Drawing.Point(306, 395);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(150, 50);
            this.btnObrisi.TabIndex = 17;
            this.btnObrisi.Text = "Obriši pomak";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // lblBrojPomakaNaDatum
            // 
            this.lblBrojPomakaNaDatum.AutoSize = true;
            this.lblBrojPomakaNaDatum.Location = new System.Drawing.Point(12, 432);
            this.lblBrojPomakaNaDatum.Name = "lblBrojPomakaNaDatum";
            this.lblBrojPomakaNaDatum.Size = new System.Drawing.Size(35, 13);
            this.lblBrojPomakaNaDatum.TabIndex = 18;
            this.lblBrojPomakaNaDatum.Text = "label1";
            // 
            // PomaciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::APT.Properties.Resources.logo_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.ControlBox = false;
            this.Controls.Add(this.lblBrojPomakaNaDatum);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvPomaciNaDatum);
            this.Controls.Add(this.btnSpremiPomak);
            this.Controls.Add(this.dtpVrijemePomaka);
            this.Controls.Add(this.dtpDatumPomaka);
            this.Controls.Add(this.btnPovratak);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PomaciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomaci";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPomaciNaDatum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.DateTimePicker dtpVrijemePomaka;
        private System.Windows.Forms.DateTimePicker dtpDatumPomaka;
        private System.Windows.Forms.Button btnSpremiPomak;
        private System.Windows.Forms.DataGridView dgvPomaciNaDatum;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblBrojPomakaNaDatum;
    }
}