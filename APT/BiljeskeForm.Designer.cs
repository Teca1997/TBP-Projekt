
namespace APT
{
    partial class BiljeskeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiljeskeForm));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.txtBiljeska = new System.Windows.Forms.TextBox();
            this.dgvBiljeske = new System.Windows.Forms.DataGridView();
            this.btnSpremiBiljesku = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dtpDatumBiljeske = new System.Windows.Forms.DateTimePicker();
            this.btnOtvoriBiljesku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiljeske)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPovratak.Location = new System.Drawing.Point(618, 395);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(150, 50);
            this.btnPovratak.TabIndex = 6;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // txtBiljeska
            // 
            this.txtBiljeska.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiljeska.Location = new System.Drawing.Point(12, 286);
            this.txtBiljeska.Multiline = true;
            this.txtBiljeska.Name = "txtBiljeska";
            this.txtBiljeska.Size = new System.Drawing.Size(288, 159);
            this.txtBiljeska.TabIndex = 7;
            this.txtBiljeska.Enter += new System.EventHandler(this.txtBiljeska_Enter);
            this.txtBiljeska.Leave += new System.EventHandler(this.txtBiljeska_Leave);
            // 
            // dgvBiljeske
            // 
            this.dgvBiljeske.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiljeske.Location = new System.Drawing.Point(12, 12);
            this.dgvBiljeske.Name = "dgvBiljeske";
            this.dgvBiljeske.Size = new System.Drawing.Size(756, 268);
            this.dgvBiljeske.TabIndex = 8;
            this.dgvBiljeske.SelectionChanged += new System.EventHandler(this.dgvBiljeske_SelectionChanged);
            // 
            // btnSpremiBiljesku
            // 
            this.btnSpremiBiljesku.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSpremiBiljesku.Location = new System.Drawing.Point(462, 395);
            this.btnSpremiBiljesku.Name = "btnSpremiBiljesku";
            this.btnSpremiBiljesku.Size = new System.Drawing.Size(150, 50);
            this.btnSpremiBiljesku.TabIndex = 9;
            this.btnSpremiBiljesku.Text = "Spremi bilješku";
            this.btnSpremiBiljesku.UseVisualStyleBackColor = false;
            this.btnSpremiBiljesku.Click += new System.EventHandler(this.btnSpremiBiljesku_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnObrisi.Location = new System.Drawing.Point(306, 395);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(150, 50);
            this.btnObrisi.TabIndex = 10;
            this.btnObrisi.Text = "Obriši bilješku";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dtpDatumBiljeske
            // 
            this.dtpDatumBiljeske.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumBiljeske.Location = new System.Drawing.Point(306, 288);
            this.dtpDatumBiljeske.Name = "dtpDatumBiljeske";
            this.dtpDatumBiljeske.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumBiljeske.TabIndex = 11;
            this.dtpDatumBiljeske.ValueChanged += new System.EventHandler(this.dtpDatumBiljeske_ValueChanged);
            // 
            // btnOtvoriBiljesku
            // 
            this.btnOtvoriBiljesku.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOtvoriBiljesku.Location = new System.Drawing.Point(306, 339);
            this.btnOtvoriBiljesku.Name = "btnOtvoriBiljesku";
            this.btnOtvoriBiljesku.Size = new System.Drawing.Size(150, 50);
            this.btnOtvoriBiljesku.TabIndex = 12;
            this.btnOtvoriBiljesku.Text = "Otvori bilješku";
            this.btnOtvoriBiljesku.UseVisualStyleBackColor = false;
            this.btnOtvoriBiljesku.Click += new System.EventHandler(this.btnOtvoriBiljesku_Click);
            // 
            // BiljeskeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::APT.Properties.Resources.logo_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.ControlBox = false;
            this.Controls.Add(this.btnOtvoriBiljesku);
            this.Controls.Add(this.dtpDatumBiljeske);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSpremiBiljesku);
            this.Controls.Add(this.dgvBiljeske);
            this.Controls.Add(this.txtBiljeska);
            this.Controls.Add(this.btnPovratak);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BiljeskeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biljeske";
            this.VisibleChanged += new System.EventHandler(this.BiljeskeForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiljeske)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.TextBox txtBiljeska;
        private System.Windows.Forms.DataGridView dgvBiljeske;
        private System.Windows.Forms.Button btnSpremiBiljesku;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DateTimePicker dtpDatumBiljeske;
        private System.Windows.Forms.Button btnOtvoriBiljesku;
    }
}