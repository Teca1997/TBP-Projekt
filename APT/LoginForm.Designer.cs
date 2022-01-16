
namespace APT
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.btnToggleLozinka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPovratak.Location = new System.Drawing.Point(67, 146);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(150, 50);
            this.btnPovratak.TabIndex = 4;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrijaviSe.Location = new System.Drawing.Point(67, 90);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(150, 50);
            this.btnPrijaviSe.TabIndex = 3;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(52, 28);
            this.txtBoxEmail.Multiline = true;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(180, 25);
            this.txtBoxEmail.TabIndex = 1;
            this.txtBoxEmail.Text = "Email";
            this.txtBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEmail.Enter += new System.EventHandler(this.txtBoxEmail_Enter);
            this.txtBoxEmail.Leave += new System.EventHandler(this.txtBoxEmail_Leave);
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLozinka.Location = new System.Drawing.Point(52, 59);
            this.txtBoxLozinka.Multiline = true;
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.Size = new System.Drawing.Size(180, 25);
            this.txtBoxLozinka.TabIndex = 2;
            this.txtBoxLozinka.Text = "Lozinka";
            this.txtBoxLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxLozinka.TextChanged += new System.EventHandler(this.txtBoxLozinka_TextChanged);
            this.txtBoxLozinka.Enter += new System.EventHandler(this.txtBoxLozinka_Enter);
            this.txtBoxLozinka.Leave += new System.EventHandler(this.txtBoxLozinka_Leave);
            // 
            // btnToggleLozinka
            // 
            this.btnToggleLozinka.BackgroundImage = global::APT.Properties.Resources.download;
            this.btnToggleLozinka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToggleLozinka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleLozinka.FlatAppearance.BorderSize = 0;
            this.btnToggleLozinka.Location = new System.Drawing.Point(238, 59);
            this.btnToggleLozinka.Name = "btnToggleLozinka";
            this.btnToggleLozinka.Size = new System.Drawing.Size(25, 25);
            this.btnToggleLozinka.TabIndex = 99;
            this.btnToggleLozinka.UseVisualStyleBackColor = true;
            this.btnToggleLozinka.Click += new System.EventHandler(this.btnToggleLozinka_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::APT.Properties.Resources.logo_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnToggleLozinka);
            this.Controls.Add(this.txtBoxLozinka);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.btnPovratak);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APT - Prijavi se";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.Button btnToggleLozinka;
    }
}