
namespace APT
{
    partial class SimptomiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimptomiForm));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.clbSimptomi = new System.Windows.Forms.CheckedListBox();
            this.dtpDatumSImptoma = new System.Windows.Forms.DateTimePicker();
            this.btnDodajSimptome = new System.Windows.Forms.Button();
            this.dgvSImptomiMameNaDatum = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSImptomiMameNaDatum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPovratak.Location = new System.Drawing.Point(622, 399);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(150, 50);
            this.btnPovratak.TabIndex = 4;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // clbSimptomi
            // 
            this.clbSimptomi.CheckOnClick = true;
            this.clbSimptomi.FormattingEnabled = true;
            this.clbSimptomi.Location = new System.Drawing.Point(12, 12);
            this.clbSimptomi.Name = "clbSimptomi";
            this.clbSimptomi.Size = new System.Drawing.Size(365, 229);
            this.clbSimptomi.TabIndex = 5;
            // 
            // dtpDatumSImptoma
            // 
            this.dtpDatumSImptoma.Location = new System.Drawing.Point(12, 247);
            this.dtpDatumSImptoma.Name = "dtpDatumSImptoma";
            this.dtpDatumSImptoma.Size = new System.Drawing.Size(367, 20);
            this.dtpDatumSImptoma.TabIndex = 6;
            this.dtpDatumSImptoma.ValueChanged += new System.EventHandler(this.dtpDatumSImptoma_ValueChanged);
            // 
            // btnDodajSimptome
            // 
            this.btnDodajSimptome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajSimptome.Location = new System.Drawing.Point(466, 399);
            this.btnDodajSimptome.Name = "btnDodajSimptome";
            this.btnDodajSimptome.Size = new System.Drawing.Size(150, 50);
            this.btnDodajSimptome.TabIndex = 7;
            this.btnDodajSimptome.Text = "Ažuriraj simptome";
            this.btnDodajSimptome.UseVisualStyleBackColor = false;
            this.btnDodajSimptome.Click += new System.EventHandler(this.btnDodajSimptome_Click);
            // 
            // dgvSImptomiMameNaDatum
            // 
            this.dgvSImptomiMameNaDatum.AllowUserToOrderColumns = true;
            this.dgvSImptomiMameNaDatum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSImptomiMameNaDatum.Location = new System.Drawing.Point(411, 12);
            this.dgvSImptomiMameNaDatum.Name = "dgvSImptomiMameNaDatum";
            this.dgvSImptomiMameNaDatum.Size = new System.Drawing.Size(361, 229);
            this.dgvSImptomiMameNaDatum.TabIndex = 8;
            // 
            // SimptomiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::APT.Properties.Resources.logo_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.dgvSImptomiMameNaDatum);
            this.Controls.Add(this.btnDodajSimptome);
            this.Controls.Add(this.dtpDatumSImptoma);
            this.Controls.Add(this.clbSimptomi);
            this.Controls.Add(this.btnPovratak);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimptomiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simptomi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSImptomiMameNaDatum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.CheckedListBox clbSimptomi;
        private System.Windows.Forms.DateTimePicker dtpDatumSImptoma;
        private System.Windows.Forms.Button btnDodajSimptome;
        private System.Windows.Forms.DataGridView dgvSImptomiMameNaDatum;
    }
}