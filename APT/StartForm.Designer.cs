
namespace APT
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.btnRegistrirajSe = new System.Windows.Forms.Button();
            this.btnIzadi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrijaviSe.Location = new System.Drawing.Point(64, 17);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(150, 50);
            this.btnPrijaviSe.TabIndex = 0;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // btnRegistrirajSe
            // 
            this.btnRegistrirajSe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrirajSe.Location = new System.Drawing.Point(64, 73);
            this.btnRegistrirajSe.Name = "btnRegistrirajSe";
            this.btnRegistrirajSe.Size = new System.Drawing.Size(150, 50);
            this.btnRegistrirajSe.TabIndex = 1;
            this.btnRegistrirajSe.Text = "Registriraj se";
            this.btnRegistrirajSe.UseVisualStyleBackColor = false;
            this.btnRegistrirajSe.Click += new System.EventHandler(this.btnRegistrirajSe_Click);
            // 
            // btnIzadi
            // 
            this.btnIzadi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzadi.Location = new System.Drawing.Point(64, 129);
            this.btnIzadi.Name = "btnIzadi";
            this.btnIzadi.Size = new System.Drawing.Size(150, 50);
            this.btnIzadi.TabIndex = 3;
            this.btnIzadi.Text = "Izađi iz aplikacije";
            this.btnIzadi.UseVisualStyleBackColor = false;
            this.btnIzadi.Click += new System.EventHandler(this.btnIzadi_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::APT.Properties.Resources.logo_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(280, 257);
            this.ControlBox = false;
            this.Controls.Add(this.btnIzadi);
            this.Controls.Add(this.btnRegistrirajSe);
            this.Controls.Add(this.btnPrijaviSe);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.Button btnRegistrirajSe;
        private System.Windows.Forms.Button btnIzadi;
    }
}

