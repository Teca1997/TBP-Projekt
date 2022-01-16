
namespace APT
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.txtBoxLozinkaPonovljena = new System.Windows.Forms.TextBox();
            this.btnRegistrairajSe = new System.Windows.Forms.Button();
            this.btnToggleLozinka = new System.Windows.Forms.Button();
            this.btnToggleLozinkaPonovljena = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblTerminPoroda = new System.Windows.Forms.Label();
            this.dtpTerminPoroda = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPovratak.Location = new System.Drawing.Point(73, 290);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(150, 50);
            this.btnPovratak.TabIndex = 2;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIme.Location = new System.Drawing.Point(56, 20);
            this.txtBoxIme.Multiline = true;
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(180, 25);
            this.txtBoxIme.TabIndex = 4;
            this.txtBoxIme.Text = "Ime";
            this.txtBoxIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxIme.Enter += new System.EventHandler(this.txtBoxIme_Enter);
            this.txtBoxIme.Leave += new System.EventHandler(this.txtBoxIme_Leave);
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrezime.Location = new System.Drawing.Point(56, 51);
            this.txtBoxPrezime.Multiline = true;
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(180, 25);
            this.txtBoxPrezime.TabIndex = 5;
            this.txtBoxPrezime.Text = "Prezime";
            this.txtBoxPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxPrezime.Enter += new System.EventHandler(this.txtBoxPrezime_Enter);
            this.txtBoxPrezime.Leave += new System.EventHandler(this.txtBoxPrezime_Leave);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(56, 82);
            this.txtBoxEmail.Multiline = true;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(180, 25);
            this.txtBoxEmail.TabIndex = 7;
            this.txtBoxEmail.Text = "Email";
            this.txtBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEmail.Enter += new System.EventHandler(this.txtBoxEmail_Enter);
            this.txtBoxEmail.Leave += new System.EventHandler(this.txtBoxEmail_Leave);
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLozinka.Location = new System.Drawing.Point(56, 113);
            this.txtBoxLozinka.Multiline = true;
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.Size = new System.Drawing.Size(180, 25);
            this.txtBoxLozinka.TabIndex = 8;
            this.txtBoxLozinka.Text = "Lozinka";
            this.txtBoxLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxLozinka.TextChanged += new System.EventHandler(this.txtBoxLozinka_TextChanged);
            this.txtBoxLozinka.Enter += new System.EventHandler(this.txtBoxLozinka_Enter);
            this.txtBoxLozinka.Leave += new System.EventHandler(this.txtBoxLozinka_Leave);
            // 
            // txtBoxLozinkaPonovljena
            // 
            this.txtBoxLozinkaPonovljena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLozinkaPonovljena.Location = new System.Drawing.Point(56, 144);
            this.txtBoxLozinkaPonovljena.Multiline = true;
            this.txtBoxLozinkaPonovljena.Name = "txtBoxLozinkaPonovljena";
            this.txtBoxLozinkaPonovljena.Size = new System.Drawing.Size(180, 25);
            this.txtBoxLozinkaPonovljena.TabIndex = 9;
            this.txtBoxLozinkaPonovljena.Text = "Ponovite lozinku";
            this.txtBoxLozinkaPonovljena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxLozinkaPonovljena.TextChanged += new System.EventHandler(this.txtBoxLozinkaPonovljena_TextChanged);
            this.txtBoxLozinkaPonovljena.Enter += new System.EventHandler(this.txtBoxLozinkaPonovljena_Enter);
            this.txtBoxLozinkaPonovljena.Leave += new System.EventHandler(this.txtBoxLozinkaPonovljena_Leave);
            // 
            // btnRegistrairajSe
            // 
            this.btnRegistrairajSe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrairajSe.Location = new System.Drawing.Point(73, 234);
            this.btnRegistrairajSe.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnRegistrairajSe.Name = "btnRegistrairajSe";
            this.btnRegistrairajSe.Size = new System.Drawing.Size(150, 50);
            this.btnRegistrairajSe.TabIndex = 10;
            this.btnRegistrairajSe.Text = "Registriraj se";
            this.btnRegistrairajSe.UseVisualStyleBackColor = false;
            this.btnRegistrairajSe.Click += new System.EventHandler(this.btnRegistrairajSe_Click);
            // 
            // btnToggleLozinka
            // 
            this.btnToggleLozinka.BackgroundImage = global::APT.Properties.Resources.download;
            this.btnToggleLozinka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToggleLozinka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleLozinka.FlatAppearance.BorderSize = 0;
            this.btnToggleLozinka.Location = new System.Drawing.Point(242, 113);
            this.btnToggleLozinka.Name = "btnToggleLozinka";
            this.btnToggleLozinka.Size = new System.Drawing.Size(25, 25);
            this.btnToggleLozinka.TabIndex = 11;
            this.btnToggleLozinka.UseVisualStyleBackColor = true;
            this.btnToggleLozinka.Click += new System.EventHandler(this.btnToggleLozinka_Click);
            // 
            // btnToggleLozinkaPonovljena
            // 
            this.btnToggleLozinkaPonovljena.BackgroundImage = global::APT.Properties.Resources.download;
            this.btnToggleLozinkaPonovljena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToggleLozinkaPonovljena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleLozinkaPonovljena.FlatAppearance.BorderSize = 0;
            this.btnToggleLozinkaPonovljena.Location = new System.Drawing.Point(242, 144);
            this.btnToggleLozinkaPonovljena.Name = "btnToggleLozinkaPonovljena";
            this.btnToggleLozinkaPonovljena.Size = new System.Drawing.Size(25, 25);
            this.btnToggleLozinkaPonovljena.TabIndex = 12;
            this.btnToggleLozinkaPonovljena.UseVisualStyleBackColor = true;
            this.btnToggleLozinkaPonovljena.Click += new System.EventHandler(this.btnToggleLozinkaPonovljena_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblTerminPoroda
            // 
            this.lblTerminPoroda.AutoSize = true;
            this.lblTerminPoroda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminPoroda.Location = new System.Drawing.Point(91, 172);
            this.lblTerminPoroda.Name = "lblTerminPoroda";
            this.lblTerminPoroda.Size = new System.Drawing.Size(111, 20);
            this.lblTerminPoroda.TabIndex = 18;
            this.lblTerminPoroda.Text = "Termin poroda";
            // 
            // dtpTerminPoroda
            // 
            this.dtpTerminPoroda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTerminPoroda.Location = new System.Drawing.Point(12, 195);
            this.dtpTerminPoroda.Name = "dtpTerminPoroda";
            this.dtpTerminPoroda.Size = new System.Drawing.Size(260, 26);
            this.dtpTerminPoroda.TabIndex = 17;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::APT.Properties.Resources.logo_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.ControlBox = false;
            this.Controls.Add(this.lblTerminPoroda);
            this.Controls.Add(this.dtpTerminPoroda);
            this.Controls.Add(this.btnToggleLozinkaPonovljena);
            this.Controls.Add(this.btnToggleLozinka);
            this.Controls.Add(this.btnRegistrairajSe);
            this.Controls.Add(this.txtBoxLozinkaPonovljena);
            this.Controls.Add(this.txtBoxLozinka);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxPrezime);
            this.Controls.Add(this.txtBoxIme);
            this.Controls.Add(this.btnPovratak);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APT - Registriraj se";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.TextBox txtBoxLozinkaPonovljena;
        private System.Windows.Forms.Button btnRegistrairajSe;
        private System.Windows.Forms.Button btnToggleLozinka;
        private System.Windows.Forms.Button btnToggleLozinkaPonovljena;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblTerminPoroda;
        private System.Windows.Forms.DateTimePicker dtpTerminPoroda;
    }
}